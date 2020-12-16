﻿namespace DataTables.Helpers.Model
{
    /// <summary>
    /// To be applied to all columns which have searchable as true.
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Global search value.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// true if the global filter should be treated as a regular expression for advanced searching, false otherwise. Note that normally server-side processing scripts will not perform regular expression searching for performance reasons on large data sets, but it is technically possible and at the discretion of your script.
        /// </summary>
        public string Regex { get; set; }
    }
}
