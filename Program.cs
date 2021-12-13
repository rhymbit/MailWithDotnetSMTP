using System.Net;
using System.Net.Mail;

// smtp client required to send the mail
SmtpClient smtp = new SmtpClient();


// constructing a mail object exposes more options
MailMessage message = new MailMessage();


message.From = new MailAddress("mail@from.com");
message.To.Add(new MailAddress("mail@to.com"));

message.Subject = "Mail Subject";

message.IsBodyHtml = true; //to make message body as html
message.Body = "<h1>Mail body is html</h1>";

smtp.Port = 587; // smtp port
smtp.Host = "smtp.gmail.com"; //for gmail host
smtp.EnableSsl = true;
smtp.UseDefaultCredentials = false;

smtp.Credentials = new NetworkCredential("mail@from.com", "password");
smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

// away goes the email
smtp.Send(message);