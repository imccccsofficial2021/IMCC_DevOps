﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MudBlazorWASM.Shared.Models
{
    public partial class LoginResult
    {
        [Key]
        public int ItemNo { get; set; }
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}