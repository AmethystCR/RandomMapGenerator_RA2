﻿using MapEditor.TileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapEditor
{
    public class AbstractUnitMap
    {
        public string MapUnitName { get; set; } = "empty";
        public bool IsOnMap { get; set; } = false;
        public bool Placed { get; set; } = false;
        public bool NWConnected { get; set; } = false;
        public bool NEConnected { get; set; } = false;
        public bool SEConnected { get; set; } = false;
        public bool SWConnected { get; set; } = false;
        public int Entropy { get; set; } = 50;
        public AbstractMapUnit GetAbstractMapUnit()
        {
            var absMapUnit = new AbstractMapUnit();
            foreach (var pAbsMapUnit in AbstractMap.AbstractMapUnitList)
            {
                if (MapUnitName == pAbsMapUnit.Name)
                {
                    absMapUnit = pAbsMapUnit;
                }
            }
            return absMapUnit;
        }
    }
}