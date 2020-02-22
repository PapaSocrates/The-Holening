// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Control/RatControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @RatControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @RatControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RatControl"",
    ""maps"": [
        {
            ""name"": ""ratControl"",
            ""id"": ""9ac4b7c4-e686-458e-bc90-e40bfe43a008"",
            ""actions"": [
                {
                    ""name"": ""TapRat"",
                    ""type"": ""Button"",
                    ""id"": ""eb33b5fa-953b-450c-9d12-96297021845d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveBox"",
                    ""type"": ""Button"",
                    ""id"": ""3f69a6b7-7cc9-4146-98ff-4664c755c231"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5dd1d5d5-b2d2-4af6-950f-7367630baece"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyMouse"",
                    ""action"": ""TapRat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0e3c90ca-b66d-4893-86ea-5070301c2863"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBox"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""938b50db-2cf9-428e-b217-e710c52d6995"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyMouse"",
                    ""action"": ""MoveBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""be9d1e7a-2e3c-49fd-a381-bd37430ac56d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyMouse"",
            ""bindingGroup"": ""KeyMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Phone"",
            ""bindingGroup"": ""Phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ratControl
        m_ratControl = asset.FindActionMap("ratControl", throwIfNotFound: true);
        m_ratControl_TapRat = m_ratControl.FindAction("TapRat", throwIfNotFound: true);
        m_ratControl_MoveBox = m_ratControl.FindAction("MoveBox", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ratControl
    private readonly InputActionMap m_ratControl;
    private IRatControlActions m_RatControlActionsCallbackInterface;
    private readonly InputAction m_ratControl_TapRat;
    private readonly InputAction m_ratControl_MoveBox;
    public struct RatControlActions
    {
        private @RatControl m_Wrapper;
        public RatControlActions(@RatControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @TapRat => m_Wrapper.m_ratControl_TapRat;
        public InputAction @MoveBox => m_Wrapper.m_ratControl_MoveBox;
        public InputActionMap Get() { return m_Wrapper.m_ratControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RatControlActions set) { return set.Get(); }
        public void SetCallbacks(IRatControlActions instance)
        {
            if (m_Wrapper.m_RatControlActionsCallbackInterface != null)
            {
                @TapRat.started -= m_Wrapper.m_RatControlActionsCallbackInterface.OnTapRat;
                @TapRat.performed -= m_Wrapper.m_RatControlActionsCallbackInterface.OnTapRat;
                @TapRat.canceled -= m_Wrapper.m_RatControlActionsCallbackInterface.OnTapRat;
                @MoveBox.started -= m_Wrapper.m_RatControlActionsCallbackInterface.OnMoveBox;
                @MoveBox.performed -= m_Wrapper.m_RatControlActionsCallbackInterface.OnMoveBox;
                @MoveBox.canceled -= m_Wrapper.m_RatControlActionsCallbackInterface.OnMoveBox;
            }
            m_Wrapper.m_RatControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TapRat.started += instance.OnTapRat;
                @TapRat.performed += instance.OnTapRat;
                @TapRat.canceled += instance.OnTapRat;
                @MoveBox.started += instance.OnMoveBox;
                @MoveBox.performed += instance.OnMoveBox;
                @MoveBox.canceled += instance.OnMoveBox;
            }
        }
    }
    public RatControlActions @ratControl => new RatControlActions(this);
    private int m_KeyMouseSchemeIndex = -1;
    public InputControlScheme KeyMouseScheme
    {
        get
        {
            if (m_KeyMouseSchemeIndex == -1) m_KeyMouseSchemeIndex = asset.FindControlSchemeIndex("KeyMouse");
            return asset.controlSchemes[m_KeyMouseSchemeIndex];
        }
    }
    private int m_PhoneSchemeIndex = -1;
    public InputControlScheme PhoneScheme
    {
        get
        {
            if (m_PhoneSchemeIndex == -1) m_PhoneSchemeIndex = asset.FindControlSchemeIndex("Phone");
            return asset.controlSchemes[m_PhoneSchemeIndex];
        }
    }
    public interface IRatControlActions
    {
        void OnTapRat(InputAction.CallbackContext context);
        void OnMoveBox(InputAction.CallbackContext context);
    }
}
