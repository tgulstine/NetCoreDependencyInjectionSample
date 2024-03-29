﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreDependencyInjection.Models;

namespace NetCoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService CustomerService { get; set; }
        private readonly ILogger _logger;

        public HomeController(ICustomerService customerService, ILogger<HomeController> logger)
        {
            CustomerService = customerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var customers = CustomerService.GetCustomers();

            _logger.LogWarning($"We only found {customers.Count()} customers");
            return View(customers);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public static class Mappers
    {
        public static Customer GetCustomer(SqlDataReader reader)
        {
            var customer = new Customer()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Address = reader.GetString(2)
            };
            return customer;
        }
    }

    public class Repository<T> : IRepository<T>
    {
        public IConfigurationSettings ConfigurationSettings { get; set; }
        private readonly ILogger _logger;

        public Repository(IConfigurationSettings configurationSettings, ILogger<Repository<T>> logger)
        {
            ConfigurationSettings = configurationSettings;
            _logger = logger;
        }

        public IEnumerable<T> Get(string commandText, Func<SqlDataReader, T> mappingFunction)
        {
            var list = new List<T>();

            _logger.LogWarning("An inefficient SELECT statement was used");

            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(commandText, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add(mappingFunction(reader));
                    }
                }
                connection.Close();
            }
            return list;
        }
    }

    public interface IRepository<T>
    {
        IConfigurationSettings ConfigurationSettings { get; set; }
        IEnumerable<T> Get(string query, Func<SqlDataReader, T> mappingFunction);
    }

    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> CustomerRepository { get; set; }

        public CustomerService(IRepository<Customer> customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return CustomerRepository.Get("SELECT Id, Name, Address FROM Customers", Mappers.GetCustomer);
        }
    }

    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
    }

    public class ConfigurationSettings : IConfigurationSettings
    {
        public string ConnectionString { get; set; }
    }

    public interface IConfigurationSettings
    {
        string ConnectionString { get; set; }
    }

}
