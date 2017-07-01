<p align="center"><img src="http://i.imgur.com/RBPGDSr.png" height="300"></p>

# About Filtration Phone Spammer

Filtration phone spammer offers you the chance to spam phone numbers with your desired message. Customize your message, add multiple numbers and enjoy


<td><img src="http://i.imgur.com/JSy33GF.png" height="300" hspace="20"></td><td><img src="http://i.imgur.com/hSwMdU3.png" width="500" hspace="20"></td>



- You will need a Twilio account. You can register and get one here: https://www.twilio.com/
- Open the spammer.cs file and look for the line that is: 
    
      private List<string> numbers = new List<string>(new string[] { "+441344207846" });
	
- Remove the the number and add your own numbers, if you have more than one, seperate them like

      private List<string> numbers = new List<string>(new string[] { "+441344207846", "+00000", "+3455432" });
	
	
- Open the program and click Tools > Settings. Add your AuthToken and Account ID, and Spam Message
- Once saved, close the settings and add the number in to the text box you would like to spam, and click "Spam"
- It will now spam call that phone with the specified message.
