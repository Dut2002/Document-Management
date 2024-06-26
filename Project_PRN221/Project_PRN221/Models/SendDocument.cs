﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_PRN221.Models
{
    public partial class SendDocument
    {
        public int SendId { get; set; }
        public int UserIdSend { get; set; }
        public int UserIdReceive { get; set; }
        [Required(ErrorMessage = "Không được trống")]
        public int DocumentId { get; set; }
        public DateTime SentDate { get; set; }
        public string? Message { get; set; }
        public bool IsRead { get; set; }

        public virtual Document Document { get; set; } = null!;
        public virtual User UserIdSendNavigation { get; set; } = null!;
    }
}
