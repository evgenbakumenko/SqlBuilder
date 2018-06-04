﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SqlBuilder.Interfaces
{

	public interface IStatementUpdate : IStatement
	{

		ISetList Sets { get; set; }

		IWhereList Where { get; set; }

	}

}