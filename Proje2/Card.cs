using System;

namespace Proje2
{
    public class Card{
        private string title;
        private string description;
        private int employee;
        private int size;
        private string status;

        public Card(string title, string description, int employee, int size, string status)
        {
            this.Title = title;
            this.Description = description;
            this.Employee = employee;
            this.Size = size;
            this.Status = status;
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int Employee { get => employee; set => employee = value; }
        public int Size { get => size; set => size = value; }
        public string Status { get => status; set => status = value; }
    }
}