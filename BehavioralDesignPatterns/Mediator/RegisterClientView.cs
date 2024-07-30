﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class RegisterClientView : IMediator
    {
        private Checkbox _clientType;
        private Button _submitButton;

        public RegisterClientView(Checkbox clientType, Button submitButton)
        {
            _clientType = clientType;
            _submitButton = submitButton;

            _clientType.SetMediator(this);
            _submitButton.SetMediator(this);
        }

        public void Notify(Component sender, string @event)
        {
            if(@event == "checkbox selected")
            {
                _submitButton.Render();
            }
            else if (@event == "click")
            {
                _clientType.SaveValue();
            }
        }
    }
}
