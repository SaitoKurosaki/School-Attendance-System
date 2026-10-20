using System;
using System.Net;
using System.Net.Mail;

namespace School_Attendance_System
{
    public record AttendanceNotice(DateTime AttendanceDate,
        string ParentEmail, string StudentName, string Status, string Course, string Section, string Remarks);

    public static class ParentNotifier
    {
        private const string SenderEmail = "saitoxworld@gmail.com";
        private const string SenderPassword = "rhbxxnbfhvrftxik";

        public static void Send(AttendanceNotice notice)
        {
            try
            {
                using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(SenderEmail, SenderPassword),
                    EnableSsl = true
                };
                using MailMessage mail = new MailMessage(SenderEmail, notice.ParentEmail)
                {
                    Subject = $"Attendance Notice: {notice.StudentName} was marked {notice.Status}",
                    IsBodyHtml = true,
                    Body = BuildBody(notice)
                };
                smtp.Send(mail);
            }
            catch (SmtpException) { }
            catch (FormatException) { }
            catch (InvalidOperationException) { }
            catch (ArgumentException) { }
        }

        private static string BuildBody(AttendanceNotice notice)
        {
            string name = WebUtility.HtmlEncode(notice.StudentName);
            string course = WebUtility.HtmlEncode(notice.Course);
            string section = WebUtility.HtmlEncode(notice.Section);
            string remarks = string.IsNullOrWhiteSpace(notice.Remarks) ? "None" : WebUtility.HtmlEncode(notice.Remarks);
            string date = notice.AttendanceDate.ToString("MMMM dd, yyyy");
            string statusColor = notice.Status switch { "Absent" => "#dc2626", "Late" => "#d97706", _ => "#16a34a" };

            return $@"<!doctype html>
<html>
  <body style=""margin:0;padding:0;background-color:#f4f4f5;font-family:Arial,Helvetica,sans-serif;"">
    <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""padding:40px 15px"">
      <tr><td align=""center"">
        <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""max-width:500px;background-color:#ffffff;border-radius:12px;overflow:hidden;"">
          <tr><td style=""background-color:#0066cc;padding:25px;text-align:center;"">
            <h1 style=""margin:0;color:#ffffff;font-size:24px"">School Attendance System</h1>
          </td></tr>
          <tr><td style=""padding:35px 30px"">
            <h2 style=""margin:0 0 15px 0;color:#222222;font-size:22px"">Attendance Notice</h2>
            <p style=""margin:0 0 20px 0;color:#666666;font-size:15px;line-height:1.6;"">
              Dear Parent/Guardian, this is to inform you that <b>{name}</b> was marked
              <b style=""color:{statusColor}"">{notice.Status}</b> on {date}.
            </p>
            <table width=""100%"" cellpadding=""8"" cellspacing=""0"" style=""background-color:#f3f4f6;border-radius:10px;font-size:14px;color:#333333;"">
              <tr><td><b>Date</b></td><td>{date}</td></tr>
              <tr><td><b>Course</b></td><td>{course}</td></tr>
              <tr><td><b>Section</b></td><td>{section}</td></tr>
              <tr><td><b>Status</b></td><td>{notice.Status}</td></tr>
              <tr><td><b>Remarks</b></td><td>{remarks}</td></tr>
            </table>
            <p style=""margin:25px 0 0 0;color:#999999;font-size:12px;line-height:1.5;"">
              This is an automated message. Please contact the teacher if you have questions.
            </p>
          </td></tr>
          <tr><td style=""background-color:#f9fafb;padding:20px;text-align:center;"">
            <p style=""margin:0;color:#999999;font-size:12px"">&copy; 2026 BSCS. All rights reserved.</p>
          </td></tr>
        </table>
      </td></tr>
    </table>
  </body>
</html>";
        }
    }
}
