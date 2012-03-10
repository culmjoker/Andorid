﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.ComponentModel;

namespace GameData
{
    [Serializable]
    public class Animation
    {
        string mName = "";
        [XmlAttribute("Name"), DefaultValue("")]
        public string Name { get { return mName; } set { mName = value; } }

        bool mEnabled = true;
        [XmlAttribute("Enabled"), DefaultValue(true)]
        public bool Enabled { get { return mEnabled; } set { mEnabled = value; } }

        List<AnimationTrack> mAnimTracks = new List<AnimationTrack>();
        public List<AnimationTrack> AnimTracks { get { return mAnimTracks; } }

    }
}
