using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("invoices")]
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal TotalAmount { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
        public DateTime DueDate { get; set; }
        public decimal PaidAmount { get; set; } = 0;

        public string Description { get; set; }

        // Relacja z kontrahentem
        public int ContractorId { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}