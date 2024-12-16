//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/Input/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""GameInteractions"",
            ""id"": ""ba65e652-0c0c-4748-8a9f-428c81e15e22"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5ca3c832-1b63-4f83-a160-0c9d55099029"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""538fe7c3-328b-44b5-bcd6-029e59ced67a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a5948f3b-775c-447f-897d-8d4f6d35572f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7406275c-30d5-45e1-b622-b6c510b1dded"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fac7bf38-f95c-4e69-a826-924aefc6ac57"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""284dee53-a2ad-49cd-8906-4e7bd8cd581b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33d6ffc9-6692-4c40-810f-39dd00bce147"",
                    ""path"": ""<Pointer>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2176855e-f5cd-4fc4-9b04-81dd428ed837"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraInteraction"",
            ""id"": ""50dda610-67c3-4a18-8487-3df5dc0f19f4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1a52b207-2002-4a87-a517-a53729dc0597"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""3d01b733-119f-4a49-99d6-fdeca780b678"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""099fc9f2-77c0-4e59-bf6c-4f5d9479da6e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7f4d5750-89d4-49c9-bc3f-b256393e6014"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac12c635-7640-4319-ba8f-7b3c69ff0566"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e505441b-fb4f-4bea-a148-7f7cd3d8e200"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""15bdc850-1036-4a69-96b6-d4a4f7c65a16"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e0c8efc9-545c-4578-880a-780f36818eb2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d4b25f2e-236f-4c17-9d5b-f3dd447a9b82"",
                    ""path"": ""<Mouse>/scroll/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9a8552f4-4089-4aca-bf9c-187780d8ae89"",
                    ""path"": ""<Mouse>/scroll/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameInteractions
        m_GameInteractions = asset.FindActionMap("GameInteractions", throwIfNotFound: true);
        m_GameInteractions_Move = m_GameInteractions.FindAction("Move", throwIfNotFound: true);
        m_GameInteractions_Click = m_GameInteractions.FindAction("Click", throwIfNotFound: true);
        // CameraInteraction
        m_CameraInteraction = asset.FindActionMap("CameraInteraction", throwIfNotFound: true);
        m_CameraInteraction_Move = m_CameraInteraction.FindAction("Move", throwIfNotFound: true);
        m_CameraInteraction_Zoom = m_CameraInteraction.FindAction("Zoom", throwIfNotFound: true);
    }

    ~@Controls()
    {
        UnityEngine.Debug.Assert(!m_GameInteractions.enabled, "This will cause a leak and performance issues, Controls.GameInteractions.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_CameraInteraction.enabled, "This will cause a leak and performance issues, Controls.CameraInteraction.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // GameInteractions
    private readonly InputActionMap m_GameInteractions;
    private List<IGameInteractionsActions> m_GameInteractionsActionsCallbackInterfaces = new List<IGameInteractionsActions>();
    private readonly InputAction m_GameInteractions_Move;
    private readonly InputAction m_GameInteractions_Click;
    public struct GameInteractionsActions
    {
        private @Controls m_Wrapper;
        public GameInteractionsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GameInteractions_Move;
        public InputAction @Click => m_Wrapper.m_GameInteractions_Click;
        public InputActionMap Get() { return m_Wrapper.m_GameInteractions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameInteractionsActions set) { return set.Get(); }
        public void AddCallbacks(IGameInteractionsActions instance)
        {
            if (instance == null || m_Wrapper.m_GameInteractionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameInteractionsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
        }

        private void UnregisterCallbacks(IGameInteractionsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
        }

        public void RemoveCallbacks(IGameInteractionsActions instance)
        {
            if (m_Wrapper.m_GameInteractionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameInteractionsActions instance)
        {
            foreach (var item in m_Wrapper.m_GameInteractionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameInteractionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameInteractionsActions @GameInteractions => new GameInteractionsActions(this);

    // CameraInteraction
    private readonly InputActionMap m_CameraInteraction;
    private List<ICameraInteractionActions> m_CameraInteractionActionsCallbackInterfaces = new List<ICameraInteractionActions>();
    private readonly InputAction m_CameraInteraction_Move;
    private readonly InputAction m_CameraInteraction_Zoom;
    public struct CameraInteractionActions
    {
        private @Controls m_Wrapper;
        public CameraInteractionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CameraInteraction_Move;
        public InputAction @Zoom => m_Wrapper.m_CameraInteraction_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_CameraInteraction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraInteractionActions set) { return set.Get(); }
        public void AddCallbacks(ICameraInteractionActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraInteractionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraInteractionActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
        }

        private void UnregisterCallbacks(ICameraInteractionActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
        }

        public void RemoveCallbacks(ICameraInteractionActions instance)
        {
            if (m_Wrapper.m_CameraInteractionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraInteractionActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraInteractionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraInteractionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraInteractionActions @CameraInteraction => new CameraInteractionActions(this);
    public interface IGameInteractionsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
    public interface ICameraInteractionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
