using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenuForNavigation.Models
{
    [Table(name: "AspNetRoleMenuPermission")]
    public class RoleMenuPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("ApplicationRole")]
        public string RoleId { get; set; }

        [ForeignKey("NavigationMenu")]
        public Guid NavigationMenuId { get; set; }

        public NavigationMenu NavigationMenu { get; set; }
    }
}
