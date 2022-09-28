using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
	public class Opening
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Id { get; }

		private static List<Opening> _jobOpenings = new List<Opening> {};

		public Opening(string title, string desc, string email, string phone)
		{
			Title = title;
			Description = desc;
			Email = email;
			Phone = phone;
			_jobOpenings.Add(this);
			Id = _jobOpenings.Count;
		}

		public static List<Opening> GetJobs()
		{
			return _jobOpenings;
		}

		public static void ClearJobs()
		{
			_jobOpenings.Clear();
		}
    public static Opening Find(int searchId)
    {
      return _jobOpenings[searchId-1];
    }
	}
}