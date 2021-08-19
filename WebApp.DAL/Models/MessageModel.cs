using System;

namespace WebApp.DAL.Models
{
	public class MessageModel
	{
		public Guid MessageId { get; set; }
		public DateTime Date { get; set; }
		public string Message { get; set; }
	}
}
