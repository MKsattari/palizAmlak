using System;
using System.Data;
using System.Data.Common;

namespace amlak.DataAccess.Adapters
{
	/// <summary>
	/// Event Handler for the RowUpdating Event raised by the DataAdapters
	/// </summary>
	public delegate void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e);

	/// <summary>
	/// Event Handler for the RowUpdated Event raised by the DataAdapters
	/// </summary>
	public delegate void RowUpdatedEventHandler(object sender, RowUpdatedEventArgs e);
}
