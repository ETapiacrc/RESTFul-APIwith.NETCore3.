﻿namespace BPark.infrastructure.Entities
{
    public partial class Comment
    {
        public int CommentID { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
 
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
        //wewer


    }
}
