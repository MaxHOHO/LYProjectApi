﻿using SqlSugar;

namespace LYProjectApi.Model
{
    public class RootEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true)]
        public int Id { get; set; }

      
    }
}