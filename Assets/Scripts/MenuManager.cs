using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
  [SerializeField] private Panel currentPanel = null;

  private List<Panel> panelHistory = new List<Panel>();

  bool hasPressedButton = false;

  private void Start()
  {
    SetupPanels();
  }

  private void SetupPanels()
  {
    Panel[] panels = GetComponentsInChildren<Panel>();
    foreach(Panel panel in panels)
      panel.Setup(this);

    currentPanel.Show();
  }

  private void Update()
  {
     var device = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.LeftHand, device);

      if (device[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool pressed) && pressed)
         if(pressed && !hasPressedButton)
        {
          GoToPrevious();
          hasPressedButton = true;
         } else {
          hasPressedButton = false;
         }
  }
  public void GoToPrevious()
  {
      if(panelHistory.Count == 0)
      {
        return;
      }

      int lastIndex = panelHistory.Count - 1;
      SetCurrent(panelHistory[lastIndex]);
      panelHistory.RemoveAt(lastIndex);
  }

  public void SetCurrentWithHistory(Panel newPanel)
  {
    panelHistory.Add(currentPanel);
    SetCurrent(newPanel);
  }

  private void SetCurrent(Panel newPanel)
  {
    currentPanel.Hide();
    
    currentPanel = newPanel;

    currentPanel.Show();
  }
}
