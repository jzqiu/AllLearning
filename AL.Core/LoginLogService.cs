using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AL.Component.Tools;
using AL.Core.Data;

namespace AL.Core
{
    public class LoginLogService:BaseService<SysLoginLog>
    {
        public async void InsertAsync(SysUser user)
        {
            await Insert(user);
        }

        private async Task<int> Insert(SysUser user)
        {
            var log = new SysLoginLog
            {
                LoginName = user.LoginName,
                Name = user.Name,
                UserId = user.UserId,
                LoginIp = IpAddressHelper.GetIPAddress()
            };
            var result = repository.Insert(log);
            return result;
        }
    }
}
