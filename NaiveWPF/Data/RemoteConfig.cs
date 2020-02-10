﻿using System;

namespace NaiveGUI.Data
{
    public class RemoteConfig
    {
        /// <summary>
        /// 原则上 <see cref="Name"/> 和 <see cref="Group"/> 构成唯一索引且均不可为Null
        /// </summary>
        public string Name { get; set; } = null;
        public RemoteConfigGroup Group { get; set; } = null;

        /// <summary>
        /// Obfuscates traffic by adding length paddings.
        /// </summary>
        public bool Padding { get; set; } = false;

        /// <summary>
        /// Listens at addr:port with protocol &lt;proto&gt;.
        /// Allowed values for proto: "socks", "http", "redir".
        /// </summary>
        public UriBuilder Remote { get; set; } = new UriBuilder("https://localhost")
        {
            Port = -1
        };

        public RemoteConfig(string name)
        {
            Name = name;
        }
    }
}
