﻿using System;
using System.Collections.Generic;

namespace CrudApiSolution.Models;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? IsActive { get; set; }
}
