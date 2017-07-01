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
using System.Windows.Forms;

namespace FiltrationSpammer
{
    class Spammer
    {
        public event EventHandler<string> StatusTextChanged;
        private List<string> numbers = new List<string>(new string[] { "+441344207846" });
        private List<string> numbersInUse = new List<string>();
        public string numberToCall;

        public void Main(string spamnumber)
        {
            try
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
            catch (Exception ex)
            {
                StatusTextChanged?.Invoke(this, "Error: {0}" + ex.Message);
            }
        }

        private void Call(string number)
        {
            try
            {
                var call = CallResource.Create(
                    to: new PhoneNumber(numberToCall),
                    from: new PhoneNumber(number),
                    record: true,
                    url: new Uri(String.Format("http://twimlets.com/echo?Twiml=<Response><Say>{0}</Say></Response>", core.spamMessage.Replace(" ", "+")))
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