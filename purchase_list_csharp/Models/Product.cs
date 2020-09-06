using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace purchase_list_bg.Models {

    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        private DateTime? _createdAt;

        [Column("created_at")]
        public DateTime? CreatedAt {
            get {
                return this._createdAt;
            }
            set {
                this._createdAt = value;
                if (this.ModifiedAt == null)
                {
                    this.ModifiedAt = value;
                }
            }
        }

        [Column("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [Column("created_by")]
        public int CreatedById { get; set; }

        public User CreatedBy {
            get {
                return this._createdBy;
            }
            set {
                this._createdBy = value;
                this.CreatedById = value != null ? value.Id : 0;
            }
        }
        private User _createdBy;
    }

}