// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/FartControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FartControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FartControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FartControl"",
    ""maps"": [
        {
            ""name"": ""Barffer"",
            ""id"": ""edb321ed-07a0-44ae-a3b3-f69415bd041e"",
            ""actions"": [
                {
                    ""name"": ""FartButton"",
                    ""type"": ""Button"",
                    ""id"": ""af0c7a14-ed6a-4c75-becc-d4e96557c38f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FartMove"",
                    ""type"": ""Value"",
                    ""id"": ""e19378ff-b390-485b-adff-766f64edfaa9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20755401-dec7-4c6a-8a00-7070eb93a0e5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad PS4;Keyboard"",
                    ""action"": ""FartButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25bd3be4-cad3-4ae2-8177-5df05b24d661"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad PS4;Keyboard"",
                    ""action"": ""FartButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75d8aa4d-6678-459a-8957-434f0d11ac28"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad PS4"",
                    ""action"": ""FartMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9d9d28d0-d12a-44da-ba5f-8ab458e8ec69"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FartMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5295d640-a2ee-4256-9b54-20efc0a991f9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FartMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fb8decda-16e9-4672-af3c-a7e95a038909"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FartMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""90765ed5-3813-4e9b-a632-132894aeb57e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FartMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""08049d37-2cb4-43b0-aec7-8be1ff29c8a4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FartMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad PS4"",
            ""bindingGroup"": ""Gamepad PS4"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Barffer
        m_Barffer = asset.FindActionMap("Barffer", throwIfNotFound: true);
        m_Barffer_FartButton = m_Barffer.FindAction("FartButton", throwIfNotFound: true);
        m_Barffer_FartMove = m_Barffer.FindAction("FartMove", throwIfNotFound: true);
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

    // Barffer
    private readonly InputActionMap m_Barffer;
    private IBarfferActions m_BarfferActionsCallbackInterface;
    private readonly InputAction m_Barffer_FartButton;
    private readonly InputAction m_Barffer_FartMove;
    public struct BarfferActions
    {
        private @FartControl m_Wrapper;
        public BarfferActions(@FartControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @FartButton => m_Wrapper.m_Barffer_FartButton;
        public InputAction @FartMove => m_Wrapper.m_Barffer_FartMove;
        public InputActionMap Get() { return m_Wrapper.m_Barffer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BarfferActions set) { return set.Get(); }
        public void SetCallbacks(IBarfferActions instance)
        {
            if (m_Wrapper.m_BarfferActionsCallbackInterface != null)
            {
                @FartButton.started -= m_Wrapper.m_BarfferActionsCallbackInterface.OnFartButton;
                @FartButton.performed -= m_Wrapper.m_BarfferActionsCallbackInterface.OnFartButton;
                @FartButton.canceled -= m_Wrapper.m_BarfferActionsCallbackInterface.OnFartButton;
                @FartMove.started -= m_Wrapper.m_BarfferActionsCallbackInterface.OnFartMove;
                @FartMove.performed -= m_Wrapper.m_BarfferActionsCallbackInterface.OnFartMove;
                @FartMove.canceled -= m_Wrapper.m_BarfferActionsCallbackInterface.OnFartMove;
            }
            m_Wrapper.m_BarfferActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FartButton.started += instance.OnFartButton;
                @FartButton.performed += instance.OnFartButton;
                @FartButton.canceled += instance.OnFartButton;
                @FartMove.started += instance.OnFartMove;
                @FartMove.performed += instance.OnFartMove;
                @FartMove.canceled += instance.OnFartMove;
            }
        }
    }
    public BarfferActions @Barffer => new BarfferActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadPS4SchemeIndex = -1;
    public InputControlScheme GamepadPS4Scheme
    {
        get
        {
            if (m_GamepadPS4SchemeIndex == -1) m_GamepadPS4SchemeIndex = asset.FindControlSchemeIndex("Gamepad PS4");
            return asset.controlSchemes[m_GamepadPS4SchemeIndex];
        }
    }
    public interface IBarfferActions
    {
        void OnFartButton(InputAction.CallbackContext context);
        void OnFartMove(InputAction.CallbackContext context);
    }
}
