using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using FiltrationSpammer;

namespace FiltrationSpammer
{
    class Spammer
    {
        public event EventHandler<string> StatusTextChanged;
        private List<string> numbers = new List<string>(new string[] { "+100000000", "+100000000" });
        private List<string> numbersInUse = new List<string>();

        public string numberToCall;

        public void Main(string spamnumber)
        {
            numberToCall = spamnumber;

            TwilioClient.Init(core.accountID, core.authToken);

            do
            {
                foreach (string number in numbers)
                {
                    Call(number);
                    System.Threading.Thread.Sleep(1000);
                }
            } while (true);
        }

        private void Call(string number)
        {
            try
            {
                var call = CallResource.Create(
                    to: new PhoneNumber(numberToCall),
                    from: new PhoneNumber(number),
                    record: true
                );
                StatusTextChanged?.Invoke(this, "You have called: {numberToCall} with the number {number}");
            }
            catch (Exception ex)
            {
                StatusTextChanged?.Invoke(this, "Error: {0}" + ex.Message);
            }
        }
    }
}