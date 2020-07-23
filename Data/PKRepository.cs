﻿using Microsoft.EntityFrameworkCore;
using PKWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKWebApp.Data
{
    public class PKRepository : IPKRepository
    {
        private readonly PKContext _context;

        public PKRepository(PKContext context)
        {
            _context = context;
        }

        public void AddEntity(object model)
        {
            _context.Add(model);
        }

        public IEnumerable<CoreService> GetAllCoreServices()
        {
            foreach (var coreService in _context.CoreServices)
            {
                coreService.Services = GetServicesByCoreServiceId(coreService.Id).ToList();
            }
            return _context.CoreServices
                .OrderBy(s => s.Id)
                .ToList();
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _context.Services
                .OrderBy(s => s.Id)
                .ToList();
        }
        public IEnumerable<Service> GetServicesByCoreServiceId(int coreServiceId)
        {
            return _context.Services
                .OrderBy(s => s.Id)
                .Where(s => s.CoreService.Id == coreServiceId);
        }

        public IEnumerable<Order> GetAllTickets()
        {
            return _context.Orders
                .Include(o => o.Services)
                .Include(o => o.PKUser.UserName)
                .ToList();
        }

        public IEnumerable<CoreService> GetCoreServicesByDescription(string queryPart)
        {
            return _context.CoreServices
                .Where(d => EF.Functions.Like(d.CoreServiceDescription, "%" + queryPart + "%"))
                .ToList();
        }

        public Order GetTicketById(int id)
        {
            return _context.Orders
                .Include(o => o.Services)
                .Include(o => o.PKUser.UserName)
                .Where(o => o.Id == id)
                .FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
