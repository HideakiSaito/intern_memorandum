﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Memorandum.Models
{
  public class Goal
  {
    public int Id { get; set; }

    [DisplayName("期間")]
    public bool Isdoing { get; set; }

    [DisplayName("内容")]
    public string Content { get; set; }

    [DisplayName("チェック")]
    public bool Isdone { get; set; }
  }
}