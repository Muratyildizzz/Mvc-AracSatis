using AracSatis.Entities;
using System.Net.Mail;
using System.Net;

namespace AracSatis.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Musteri musteri)
        {
            SmtpClient smtpClient = new SmtpClient("mail.siteadresi.com", 587);
            smtpClient.Credentials = new NetworkCredential("emailKullanıcıad", "emailşifre");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("info@siteadi.com");
            message.To.Add("info@siteadi.com");
            message.To.Add("bilgi@siteadi.com");
            message.Subject = "Siteden mesaj geldi";
            message.Body = $"Mail Bilgileri <hr/> Ad Soyad : {musteri.Adi} {musteri.Soyadi} <hr/> İlgilendiği Araç Id : {musteri.AracId} <hr/> Email : {musteri.Email} <hr/> Telefon : {musteri.Telefon} <hr/> Notlar : {musteri.Notlar}";
            message.IsBodyHtml = true;
            // smtpClient.Send(message);
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();
        }
    }
}