﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Model;

namespace ServiceLibrary.Interfaces
{
	public interface IMasterService
	{
		int Add(User user);

		bool Update(User user);

		bool Delete(User user);

		User GetUserById(int id);

		IList<User> SearchByName(User user);

		IList<User> SearchByLastName(User user);

		IList<User> SearchByLastAndFirstName(User user);

		IList<User> GetUsers();
	}
}
