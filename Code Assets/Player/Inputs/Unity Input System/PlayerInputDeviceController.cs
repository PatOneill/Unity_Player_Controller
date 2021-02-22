// GENERATED AUTOMATICALLY FROM 'Assets/Code/Player/Inputs/Unity Input System/PlayerInputDeviceController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputDeviceController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputDeviceController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputDeviceController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""0f8a0191-9372-455f-b54b-26513139d786"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""426f817a-3aca-4c4c-994e-d454b85fff8e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""06cd232b-a3cd-49ce-b030-ff4311dd6c0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""97194896-6b8f-4b79-9f22-b247cc588cd4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""39861d0f-83ff-482d-9973-9669e9b2da09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""80ce083c-f6f4-47a8-84e7-64af88ef6878"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""71a3d0bd-59d3-40f6-a6bb-4bcdb61f084e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec10345d-262e-44f8-a00f-a1057bfac8c6"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55ca5aec-4fcb-449d-b293-dd3456788556"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da6458dd-386a-43a6-8aa1-fcc70ea5bdf7"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""919fbf78-3f22-4bcc-94de-c2321864b6f9"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3543dcf9-d51c-4ec3-9591-47266a9132fd"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2da23d6-0996-4f81-be16-72af5284a0df"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""328b1845-b178-4064-92df-143bd3b4fb12"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""29e2db35-dbd0-4fe0-ac0f-3992ef6c0ec5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""12149fe0-d7d2-4b8d-a7ce-c4020df973f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""be7cb5fd-5f49-4265-8ea9-e3a2045fc15b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""f727b382-ae92-484e-83ac-1b48ebe89589"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3694fcc-936a-4861-aa23-0fb392d14004"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fe4bf5b-d92a-42d0-8fb2-bc357396d3b2"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1863411a-0639-4248-8502-aaff2af6cfdf"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""967a121d-e5a7-429f-8afa-0e6245eb569f"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Walk = m_Gameplay.FindAction("Walk", throwIfNotFound: true);
        m_Gameplay_Sprint = m_Gameplay.FindAction("Sprint", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Up = m_Menu.FindAction("Up", throwIfNotFound: true);
        m_Menu_Down = m_Menu.FindAction("Down", throwIfNotFound: true);
        m_Menu_Left = m_Menu.FindAction("Left", throwIfNotFound: true);
        m_Menu_Right = m_Menu.FindAction("Right", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Walk;
    private readonly InputAction m_Gameplay_Sprint;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Interact;
    public struct GameplayActions
    {
        private @PlayerInputDeviceController m_Wrapper;
        public GameplayActions(@PlayerInputDeviceController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Gameplay_Walk;
        public InputAction @Sprint => m_Wrapper.m_Gameplay_Sprint;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWalk;
                @Sprint.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSprint;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Up;
    private readonly InputAction m_Menu_Down;
    private readonly InputAction m_Menu_Left;
    private readonly InputAction m_Menu_Right;
    public struct MenuActions
    {
        private @PlayerInputDeviceController m_Wrapper;
        public MenuActions(@PlayerInputDeviceController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Menu_Up;
        public InputAction @Down => m_Wrapper.m_Menu_Down;
        public InputAction @Left => m_Wrapper.m_Menu_Left;
        public InputAction @Right => m_Wrapper.m_Menu_Right;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameplayActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
