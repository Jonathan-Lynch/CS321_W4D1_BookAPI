using CS321_W4D1_BookAPI.Data;
using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W4D1_BookAPI.Services
{
	public class PublisherService : IPublisherService
	{
        private readonly BookContext _publisherContext;
        public PublisherService(BookContext publisherContext)
        {
            _publisherContext = publisherContext;
        }
        public Publisher Add(Publisher publisher)
        {
            _publisherContext.Publishers.Add(publisher);
            _publisherContext.SaveChanges();
            return publisher;
        }

        public Publisher Get(int id)
        {
            return _publisherContext.Publishers.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _publisherContext.Publishers.ToList();
        }

        public void Remove(Publisher publisher)
        {
            _publisherContext.Publishers.Remove(publisher);
            _publisherContext.SaveChanges();
        }

        public Publisher Update(Publisher publisher)
        {
            var currentPublisher = _publisherContext.Publishers.Find(publisher.Id);
            if (currentPublisher == null) return null;
            _publisherContext.Entry(currentPublisher).CurrentValues.SetValues(publisher);
            _publisherContext.Publishers.Update(currentPublisher);
            _publisherContext.SaveChanges();
            return currentPublisher;
        }
    }
}
