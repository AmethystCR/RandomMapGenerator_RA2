﻿using MapEditor.TileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapEditor
{
    public class AbstractTile : TileInfo.AbstractTileType
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool IsOnMap { get; private set; }
        public bool Edited { get; private set; }
        public void Initialize(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
            Edited = false;
            TileNum = (int)Common._000_Empty;
            SubTile = 0;
            bool isOnMap = false;
            Used = true;
            if (Y > AbstractMap.Size[0] - X
                && Y < 2 * AbstractMap.Size[1] + AbstractMap.Size[0] + 1 - X
                && Y < X + AbstractMap.Size[0]
                && Y > X - AbstractMap.Size[0])
            {
                isOnMap = true;
            }
            IsOnMap = isOnMap;
        }
        public void SetProperty(int x, int y, int z, TileInfo.AbstractTileType absTileType)
        {
            if (absTileType == null)
                return;
            TileNum = absTileType.TileNum;
            SubTile = absTileType.SubTile;
            Used = absTileType.Used;
            X = x;
            Y = y;
            Z = z;
            Z += absTileType.Z;
            Edited = true;
            bool isOnMap = false;
            if (Y > AbstractMap.Size[0] - X
                && Y < 2 * AbstractMap.Size[1] + AbstractMap.Size[0] + 1 - X
                && Y < X + AbstractMap.Size[0]
                && Y > X - AbstractMap.Size[0])
            {
                isOnMap = true;
            }
            IsOnMap = isOnMap;
        }
    }
}