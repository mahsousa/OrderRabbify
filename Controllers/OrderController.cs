using Microsoft.AspNetCore.Mvc;
using OrderRabbify.Context;
using OrderRabbify.DTOs;
using OrderRabbify.Enums;
using OrderRabbify.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderRabbify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public OrderController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public OrderResultDTO Get()
        {
            var orders = _dbContext.Orders.ToList();
            return new OrderResultDTO
            {
                Orders = orders
            };
        }

        [HttpGet("{id}")]
        public OrderModel? Get(int id)
        {
            return _dbContext.Orders.Where(orders => orders.OrderId == id).FirstOrDefault();
        }

        [HttpPost]
        public void Post([FromBody] OrderModel order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        [HttpPut("cancelar/{id}")]
        public IActionResult CancelOrder(int id)
        {
            var order = _dbContext.Orders.FirstOrDefault(o => o.OrderId == id);

            if (order == null)
            {
                return NotFound(new { message = "Pedido não encontrado." });
            }

            order.Status = OrderStatus.Cancelado;
            _dbContext.SaveChanges();

            return Ok(new { message = "Pedido cancelado com sucesso." });
        }

    }
}
