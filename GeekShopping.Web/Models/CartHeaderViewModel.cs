﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.Web.Models
{
    [Table("cart_header")]
    public class CartHeaderViewModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
        public decimal PurchaseAmount { get; set; }
    }
}