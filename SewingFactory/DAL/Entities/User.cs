using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.DAL.Entities
{
    public class User
    {

        public enum UserRole
        {
            Customer,
            Manager,
            StoreKeeper,
            Director
        }
        [Key]
        [Column(Order = 1)]
        public string Login { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Password { get; set; }
        [Required]
        public int RoleId
        {
            get
            {
                return (int)Role;
            }
            set
            {
                Role = (UserRole)value;
            }
        }
        [NotMapped]
        [EnumDataType(typeof(UserRole))]
        public UserRole Role { get; set; }
        public string Name { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Order> CreatedOrders { get; set; }
        [InverseProperty("Manager")]
        public virtual ICollection<Order> ManagedOrders { get; set; }

        //[NotMapped]
        //public UserRole SafeRole
        //{
        //    get {
        //        if (Role == "Customer")
        //            return UserRole.Customer;
        //        else if (Role == "Manager")
        //            return UserRole.Manager;
        //        else if (Role == "StoreKeeper")
        //            return UserRole.StoreKeeper;
        //        else if (Role == "Director")
        //            return UserRole.Director;
        //        else
        //            throw new Exception("wrong user role in database");
        //    }
        //    set {
        //        if (value == UserRole.Customer)
        //            Role = "Customer";
        //        else if (value == UserRole.Manager)
        //            Role = "Manager";
        //        else if (value == UserRole.StoreKeeper)
        //            Role = "StoreKeeper";
        //        else if (value == UserRole.Director)
        //            Role = "Director";
        //        else throw new Exception("wrong user role");
        //    }
        //}

    }
}
