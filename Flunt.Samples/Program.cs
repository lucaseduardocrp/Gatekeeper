﻿using System;
using Gatekeeper.Localization;
using Gatekeeper.Samples.Handlers;
using Gatekeeper.Samples.Handlers.Requests;

namespace Gatekeeper.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            GatekeeperErrorMessages.IsEmailLocalizationErrorMessage = "deve ser um E-mail";

            var request = new CreateCustomerRequest("", "");
            var handler = new CustomerHandler();
            var response = handler.Handle(request);

            if (response == false)
            {
                foreach (var item in handler.Notifications)
                {
                    Console.WriteLine($"{item.Key} - {item.Message}");
                }
            }

            Console.ReadKey();

        }
    }
}
