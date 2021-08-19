using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectDraft.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }

        public IdentityUser User{ get; set; }
        public string UserId { get; set; }
    }
}
