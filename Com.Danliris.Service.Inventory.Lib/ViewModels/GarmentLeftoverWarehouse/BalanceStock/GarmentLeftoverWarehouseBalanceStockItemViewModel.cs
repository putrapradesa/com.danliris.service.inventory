﻿using Com.Danliris.Service.Inventory.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Inventory.Lib.ViewModels.GarmentLeftoverWarehouse.BalanceStock
{
    public class GarmentLeftoverWarehouseBalanceStockItemViewModel : BasicViewModel
    {
        public UnitViewModel Unit { get; set; }

        public string PONo { get; set; }

        public ProductViewModel Product { get; set; }
        public string ProductRemark { get; set; }

        public string Composition { get; set; }
        public string Construction { get; set; }
        public int Quantity { get; set; }
        public string RONo { get; set; }

        public UomViewModel Uom { get; set; }

        public LeftoverComodityViewModel LeftoverComodity { get; set; }

        public string Yarn { get; set; }
        public string Width { get; set; }
    }
}
