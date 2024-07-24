﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class AuthenticationManager
    {
        private INotificatinSender _notificatinSender;

        public AuthenticationManager(INotificatinSender notificatinSender)
        {
            _notificatinSender = notificatinSender;
        }

        public void Authenticate(User user, string email, string password)
        {
            if (user.Email == email && user.Password == password)
            {
                _notificatinSender.SendNotification(user);
            }
        }
    }
}
