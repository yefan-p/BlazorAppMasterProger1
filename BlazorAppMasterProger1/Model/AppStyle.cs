﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppMasterProger1.Model
{
    public class AppStyle
    {
        public string Color { get; set; } = "green";

        public string Size { get; set; } = "65px";

        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            new string("Видишь ли, эльфийская красота - она как молодое вино из Боклера. А я как-то больше по водке."),
            new string("Ты чудесно пахнешь на этих похоронах"),
            new string("Хочешь меня нахер послать? Милости просим, сука, давай...")
        };

        public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
        {
            new TableListModel() { Text = "Table Dark", Value = "table-dark"},
            new TableListModel() { Text = "Table Striped", Value = "table-striped"},
            new TableListModel() { Text = "Table Bordered", Value = "table-bordered"},
        };
    }
}
