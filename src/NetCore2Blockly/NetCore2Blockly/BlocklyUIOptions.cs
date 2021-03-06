﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2Blockly
{
    /// <summary>
    /// options for UI
    /// </summary>
    public class BlocklyUIOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlocklyUIOptions"/> class.
        /// </summary>
        public BlocklyUIOptions()
        {
            StartBlocks = "";
        }
        
        /// <summary>
        /// Gets or sets the start blocks.
        /// </summary>
        /// <value>
        /// The start blocks.
        /// </value>
        public string StartBlocks { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string HeaderName { get; set; }

        /// <summary>
        /// Gets or sets the custom blocks.
        /// </summary>
        /// <value>
        /// The custom blocks.
        /// </value>
        public string CustomBlocks { get; set; }

        /// <summary>
        /// Gets or sets the run time blocks.
        /// </summary>
        /// <value>
        /// The run time blocks.
        /// </value>
        public Func<IServiceProvider, string> RunTimeString { get; set; }
    }
}
