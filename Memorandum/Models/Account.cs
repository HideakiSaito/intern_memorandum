﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Memorandum.Models
{
  public class Account
  {
    public int Id { get; set; }

    [DisplayName("名前")]
    public string Name { get; set; }

    [DisplayName("ログイン状況")]
    public bool Login { get; set; }

    [DisplayName("管理者")]
    public bool Admin { get; set; }
  }
}