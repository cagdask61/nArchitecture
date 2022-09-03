using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public bool IsApproved { get; set; }


        public Brand()
        {
        }

        public Brand(int id, string name, bool isApproved, DateTime createdDate, DateTime updatedDate) : this()
        {
            Id = id;
            Name = name;
            IsApproved = isApproved;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }

    }
}
