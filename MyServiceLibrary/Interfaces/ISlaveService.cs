﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Model;

namespace ServiceLibrary.Interfaces
{
	public interface ISlaveService
	{
		IList<User> SearchByName(User user);

		IList<User> SearchByLastName(User user);

		IList<User> SearchByLastAndFirstName(User user);
	}
}