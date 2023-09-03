﻿// Tiny Flipon by Damien Mayance
// This file is subject to the terms and conditions defined in
// file 'LICENSE.md', which is part of this source code package.

using UnityEngine;

namespace Pon
{
  public enum GarbagesType
  {
    Normal,
    Low,
    None
  }

  public enum PlayMode
  {
    Singleplayer,
    Versus
  }

  /// <summary>
  /// Grid parameters as an object you pass from menu scene to game scene.
  /// </summary>
  public class GameSettings : MonoBehaviour
  {
    #region Members

    public GridSettings gridSettings;
    public Player[] players;
    public int seed;
    public GarbagesType garbagesType = GarbagesType.Normal;
    public bool disableChains;
    public bool enableObjectives;
    public Objective objective;
    public PlayMode playMode;

    #endregion

    #region Timeline

    void Awake()
    {
            if (MapUIScript.mapInstance != null)
            {
                // set game settings based on level
                gridSettings.startLines = MapUIScript.mapInstance.numStartingLines;
            }

            DontDestroyOnLoad(gameObject);
    }


        #endregion
    }
}