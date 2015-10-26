﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Models
{
    [Table]
    public class RouteTable
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true, DbType = "INT NOT NULL IDENTITY", AutoSync = AutoSync.OnInsert)]
        public int Id { get; set; }
        [Column]
        public int RouteId { get; set; }
        [Column]
        public int Order { get; set; }
        [Column]
        public string DisplayName { get; set; }
    }
}