﻿using System;

namespace Model
{

	public class Questions
	{

		public Questions(DateTime date, string headline, string question, int rating, User user, Category category)
		{
			this.Date = date;
			this.Headline = headline;
			this.Question = question;
			this.Rating = rating;
			this.User = user;
			this.Category = category;
		}

		public Questions(DateTime date, string headline, string question, int rating, User user)
		{
			this.Date = date;
			this.Headline = headline;
			this.Question = question;
			this.Rating = rating;
			this.User = user;
		}
		public Questions(DateTime date, string headline, string question, User user, Category category)
		{
			this.Date = date;
			this.Headline = headline;
			this.Question = question;
			
			this.User = user;
			this.Category = category;
		}

		public Questions(DateTime date, string headline, string question, int rating)
		{
			this.Date = date;
			this.Headline = headline;
			this.Question = question;
			this.Rating = rating;
		}

        public Questions()
        {
			
        }

		public long QuestionsId { get; set; }
		public DateTime Date { get; set; }
		public string Headline { get; set; }
		public string Question { get; set; }
		public int Rating { get; set; }
		public User? User { get; set; } = new();
		public Category? Category { get; set; } = new();


        public List<Answers> Answers { get; set; } = new List<Answers>();
    }


}