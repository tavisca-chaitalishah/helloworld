using DataContract;
using Interface;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImplementation
{
    public class IdentityService : IIdentityService
    {
        public IdentityService(IIdentityManager manager)
        {
            _manager = manager;
        }

        IIdentityManager _manager;

        public Employee Authenticate(Credential credential)
        {
            try
            {
                var result = _manager.Authenticate(credential.ToDomainModel());
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }

        public bool ChangePassword(ChangePasswordRequest request)
        {
            try
            {
                return _manager.ChangePassword(request.Email, request.OldPassword, request.NewPassword);
            }
            catch (Exception ex)
            {
                Exception newEx;
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                return false;
            }
        }
    }
}
