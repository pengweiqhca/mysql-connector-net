﻿// Copyright © 2015, Oracle and/or its affiliates. All rights reserved.
//
// MySQL Connector/NET is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most 
// MySQL Connectors. There are special exceptions to the terms and 
// conditions of the GPLv2 as it is applied to this software, see the 
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
//
// You should have received a copy of the GNU General Public License along 
// with this program; if not, write to the Free Software Foundation, Inc., 
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using System;
using MySql.Protocol;
using MySql.Data;

namespace MySql.XDevAPI.Relational
{
  /// <summary>
  /// Represents a table column
  /// </summary>
  public class TableColumn
  {
    internal ValueDecoder _decoder;
    internal UInt64 _collationNumber;

    /// <summary>
    /// Column name
    /// </summary>
    public string Name { get; internal set; }
    /// <summary>
    /// Original column name before an alias was applied
    /// </summary>
    public string OriginalName { get; internal set; }
    /// <summary>
    /// Table name the column orginates from
    /// </summary>
    public string Table { get; internal set; }
    /// <summary>
    /// Original table name the column orginates from before an alias was applied
    /// </summary>
    public string OriginalTable { get; internal set; }
    /// <summary>
    /// Schema name the column originates from
    /// </summary>
    public string Schema { get; internal set; }
    /// <summary>
    /// Catalog the schema originates from.
    /// In MySQL protocol this is `def` by default
    /// </summary>
    public string Catalog { get; internal set;  }
    /// <summary>
    /// Collation used in column
    /// </summary>
    public string Collation { get; internal set; }
    /// <summary>
    /// Column lenght
    /// </summary>
    public UInt32 Length { get; internal set; }
    /// <summary>
    /// Fractional decimal digits for floating point and fixed point numbers
    /// </summary>
    public UInt32 FractionalDigits { get; internal set; }
    /// <summary>
    /// Mysql data type
    /// </summary>
    public MySQLDbType DbType { get; internal set; }
    /// <summary>
    /// .NET Clr data type
    /// </summary>
    public Type ClrType { get; internal set; }

  }
}
