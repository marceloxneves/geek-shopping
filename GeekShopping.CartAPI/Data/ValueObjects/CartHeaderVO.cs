﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Data.ValueObjects
{
    [Table("cart_header")]
    public class CartHeaderVO
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
        public decimal PurchaseAmount { get; set; }
    }
}
