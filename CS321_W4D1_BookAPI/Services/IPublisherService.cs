using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W4D1_BookAPI.Services
{
	interface IPublisherService
	{
		Publisher Add(Publisher publisher);
		Publisher Get(int Id);
		Publisher Update(Publisher publisher);
		void Remove(Publisher publisher);
		IEnumerable<Publisher> GetAll();
	}
}
