﻿using MonoSync.Attributes;
using MonoSync.Collections;
using PropertyChanged;

namespace MonoSync.Sample.Tweening
{
    [Synchronizable]
    [AddINotifyPropertyChangedInterface]
    public class Map
    {
        public Map() : this(new ObservableHashSet<Player>())
        {
        }

        /// <summary>
        ///     Properties can be accessed during construction using parameters.
        ///     The parameter name should be camelCase or Marked with the <see cref="SynchronizationParameterAttribute" />.
        ///     MonoSync will use the default constructor if no <see cref="SynchronizationConstructorAttribute" /> Marked constructor is
        ///     provided.
        ///     Properties that do not occur in the constructor parameter will be synchronized after the constructor call.
        /// </summary>
        /// <param name="players"></param>
        [SynchronizationConstructor]
        public Map(ObservableHashSet<Player> players)
        {
            Players = players;
        }

        [Synchronize] 
        public ObservableHashSet<Player> Players { get; set; }
    }
}