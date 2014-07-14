using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AL.Component.Data;
using AL.Component.Tools;
using AL.Core.Data;
using AL.Core.Models;

namespace AL.Core
{
    public class AccountService:BaseService<SysUser>
    {
        public OperationResult Login(SysUserDto dto)
        {
            var users = from u in repository.Entities
                       where u.LoginName == dto.LoginName
                        //&& u.Available=="1"
                       select u;
            if (users == null)
            {
                return new OperationResult(OperationResultType.QueryNull, "该用户不存在");
            }

            //MD5加密后的密码
            string pwd = GetMD5(dto.Password);
            var user = users.First();
            if (pwd != user.Password)
            {
                return new OperationResult(OperationResultType.QueryNull, "密码错误");
            }

            new LoginLogService().InsertAsync(user);

            return new OperationResult(OperationResultType.Success);
        }

        private string GetMD5(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder builder = new StringBuilder(32);
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();

            //char[] temp = new char[res.Length];
            //System.Array.Copy(res, temp, res.Length);
            //return new String(temp);
        }
    }
}
