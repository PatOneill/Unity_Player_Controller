// GENERATED AUTOMATICALLY FROM 'Assets/Player/Player Inputs/Unity Generated Scripts/InputDeviceLayout.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputDeviceLayout : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputDeviceLayout()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputDeviceLayout"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f96538a0-d982-4a57-9a16-deb0c4bc3c49"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""56eade3c-5df4-47d2-8e44-83b332ef00b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""714eb7cf-70ae-4a96-9d60-1a0f31bb5548"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""9fd1dc77-97a7-4c5d-b025-5c15e3f1e8cc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""dec86f02-24ec-4a95-99e9-fd7a6d6dff52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""85b26a23-0c1b-4f2a-ad3a-331fea95fdbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b99f1692-f0fd-424e-8f19-44556d3938bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""28b16527-f794-4eed-83d9-20b873097b91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Game Menu"",
                    ""type"": ""Button"",
                    ""id"": ""9d063db8-dd50-4956-9714-95cea9007977"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08d7da45-f079-44a2-a6b4-cd2add7277ef"",
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
                    ""id"": ""84b76383-87f6-4b2f-8226-e67e11bc42e7"",
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
                    ""id"": ""1e3420a7-923a-4b13-aa69-4b8525ea7fe1"",
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
                    ""id"": ""1eee33f3-f657-422f-8aa5-53bccffa66f8"",
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
                    ""id"": ""bdb8d984-4193-4008-b2e8-f0f18fad898d"",
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
                    ""id"": ""22632332-5fb1-4686-a91f-9dbdd3d4a455"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d29efe80-c7e3-4269-a5bd-cd453537cda3"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""533bd98e-79db-428d-8837-f7db204fb32e"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Game Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerUI"",
            ""id"": ""7bd8c22d-b6f7-45fc-941e-6d06104aacd7"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""2c515fa5-0511-4669-911a-56bf27e3b6ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TabLeft"",
                    ""type"": ""Button"",
                    ""id"": ""03a33a05-26cd-4a7c-9c1b-6959bbf69a57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TabRight"",
                    ""type"": ""Button"",
                    ""id"": ""3042baaa-985a-4bb1-b7f1-631f8ed93098"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""412b4325-74da-480b-9069-965c77da935e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AltClose"",
                    ""type"": ""Button"",
                    ""id"": ""5b319c7e-a1d5-47d6-af5b-90a6abbe5d20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUpArrow"",
                    ""type"": ""Button"",
                    ""id"": ""9b2a1a02-f8b4-45e8-a210-ec4b1b79d6de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDownArrow"",
                    ""type"": ""Button"",
                    ""id"": ""274199a8-d270-4fef-860f-c0e35eae68f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeftArrow"",
                    ""type"": ""Button"",
                    ""id"": ""4c2d4377-3cae-46da-a3d7-4ecd13d206ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRightArrow"",
                    ""type"": ""Button"",
                    ""id"": ""4d79f867-771b-4037-b102-3136ca5dd9c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUpAnalogStick"",
                    ""type"": ""Button"",
                    ""id"": ""a6b92899-4f85-46b6-9334-98212eda7b1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDownAnalogStick"",
                    ""type"": ""Button"",
                    ""id"": ""830d0cf5-f1d5-4d85-955b-a7b1220c9896"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeftAnalogStick"",
                    ""type"": ""Button"",
                    ""id"": ""b90b8d7b-35ed-4e33-8865-45adac59f702"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRightAnalogStick"",
                    ""type"": ""Button"",
                    ""id"": ""a8e71b9d-4c67-4778-bea7-def9861d63fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ad46dc46-8108-4159-a9a7-3f593918867a"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc8910fd-1d3f-449c-acdf-f8621a472fb7"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TabLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b4e0aa2-5d91-47cb-8349-4726493b7834"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TabRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""230369cb-db9f-4f78-91dc-daeb0fe24e8f"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d74e7df-7d19-4207-926d-8ec8c2d6a761"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdb4bd61-c5ab-4356-b983-3fc595b409b6"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7662106-4c49-4681-944b-829ada995704"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDownArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""200a46e8-51d8-4341-a394-bc57d5f0a0fb"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d817c9d-09c2-4883-9492-014e18e11f9a"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a61d8744-ec2b-4070-8f33-ed78859303dd"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpAnalogStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a42ce68-b738-42aa-b63e-bd510f62c4ad"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDownAnalogStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f9eee86-e7d2-4f19-b136-2411455072f2"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftAnalogStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04604ea1-3031-4f39-99d1-af45042339c6"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightAnalogStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
        m_Player_GameMenu = m_Player.FindAction("Game Menu", throwIfNotFound: true);
        // PlayerUI
        m_PlayerUI = asset.FindActionMap("PlayerUI", throwIfNotFound: true);
        m_PlayerUI_Close = m_PlayerUI.FindAction("Close", throwIfNotFound: true);
        m_PlayerUI_TabLeft = m_PlayerUI.FindAction("TabLeft", throwIfNotFound: true);
        m_PlayerUI_TabRight = m_PlayerUI.FindAction("TabRight", throwIfNotFound: true);
        m_PlayerUI_Select = m_PlayerUI.FindAction("Select", throwIfNotFound: true);
        m_PlayerUI_AltClose = m_PlayerUI.FindAction("AltClose", throwIfNotFound: true);
        m_PlayerUI_MoveUpArrow = m_PlayerUI.FindAction("MoveUpArrow", throwIfNotFound: true);
        m_PlayerUI_MoveDownArrow = m_PlayerUI.FindAction("MoveDownArrow", throwIfNotFound: true);
        m_PlayerUI_MoveLeftArrow = m_PlayerUI.FindAction("MoveLeftArrow", throwIfNotFound: true);
        m_PlayerUI_MoveRightArrow = m_PlayerUI.FindAction("MoveRightArrow", throwIfNotFound: true);
        m_PlayerUI_MoveUpAnalogStick = m_PlayerUI.FindAction("MoveUpAnalogStick", throwIfNotFound: true);
        m_PlayerUI_MoveDownAnalogStick = m_PlayerUI.FindAction("MoveDownAnalogStick", throwIfNotFound: true);
        m_PlayerUI_MoveLeftAnalogStick = m_PlayerUI.FindAction("MoveLeftAnalogStick", throwIfNotFound: true);
        m_PlayerUI_MoveRightAnalogStick = m_PlayerUI.FindAction("MoveRightAnalogStick", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Menu;
    private readonly InputAction m_Player_GameMenu;
    public struct PlayerActions
    {
        private @InputDeviceLayout m_Wrapper;
        public PlayerActions(@InputDeviceLayout wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputAction @GameMenu => m_Wrapper.m_Player_GameMenu;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @GameMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @GameMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @GameMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
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
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @GameMenu.started += instance.OnGameMenu;
                @GameMenu.performed += instance.OnGameMenu;
                @GameMenu.canceled += instance.OnGameMenu;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // PlayerUI
    private readonly InputActionMap m_PlayerUI;
    private IPlayerUIActions m_PlayerUIActionsCallbackInterface;
    private readonly InputAction m_PlayerUI_Close;
    private readonly InputAction m_PlayerUI_TabLeft;
    private readonly InputAction m_PlayerUI_TabRight;
    private readonly InputAction m_PlayerUI_Select;
    private readonly InputAction m_PlayerUI_AltClose;
    private readonly InputAction m_PlayerUI_MoveUpArrow;
    private readonly InputAction m_PlayerUI_MoveDownArrow;
    private readonly InputAction m_PlayerUI_MoveLeftArrow;
    private readonly InputAction m_PlayerUI_MoveRightArrow;
    private readonly InputAction m_PlayerUI_MoveUpAnalogStick;
    private readonly InputAction m_PlayerUI_MoveDownAnalogStick;
    private readonly InputAction m_PlayerUI_MoveLeftAnalogStick;
    private readonly InputAction m_PlayerUI_MoveRightAnalogStick;
    public struct PlayerUIActions
    {
        private @InputDeviceLayout m_Wrapper;
        public PlayerUIActions(@InputDeviceLayout wrapper) { m_Wrapper = wrapper; }
        public InputAction @Close => m_Wrapper.m_PlayerUI_Close;
        public InputAction @TabLeft => m_Wrapper.m_PlayerUI_TabLeft;
        public InputAction @TabRight => m_Wrapper.m_PlayerUI_TabRight;
        public InputAction @Select => m_Wrapper.m_PlayerUI_Select;
        public InputAction @AltClose => m_Wrapper.m_PlayerUI_AltClose;
        public InputAction @MoveUpArrow => m_Wrapper.m_PlayerUI_MoveUpArrow;
        public InputAction @MoveDownArrow => m_Wrapper.m_PlayerUI_MoveDownArrow;
        public InputAction @MoveLeftArrow => m_Wrapper.m_PlayerUI_MoveLeftArrow;
        public InputAction @MoveRightArrow => m_Wrapper.m_PlayerUI_MoveRightArrow;
        public InputAction @MoveUpAnalogStick => m_Wrapper.m_PlayerUI_MoveUpAnalogStick;
        public InputAction @MoveDownAnalogStick => m_Wrapper.m_PlayerUI_MoveDownAnalogStick;
        public InputAction @MoveLeftAnalogStick => m_Wrapper.m_PlayerUI_MoveLeftAnalogStick;
        public InputAction @MoveRightAnalogStick => m_Wrapper.m_PlayerUI_MoveRightAnalogStick;
        public InputActionMap Get() { return m_Wrapper.m_PlayerUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerUIActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerUIActions instance)
        {
            if (m_Wrapper.m_PlayerUIActionsCallbackInterface != null)
            {
                @Close.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnClose;
                @Close.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnClose;
                @Close.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnClose;
                @TabLeft.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnTabLeft;
                @TabLeft.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnTabLeft;
                @TabLeft.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnTabLeft;
                @TabRight.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnTabRight;
                @TabRight.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnTabRight;
                @TabRight.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnTabRight;
                @Select.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnSelect;
                @AltClose.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnAltClose;
                @AltClose.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnAltClose;
                @AltClose.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnAltClose;
                @MoveUpArrow.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveUpArrow;
                @MoveUpArrow.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveUpArrow;
                @MoveUpArrow.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveUpArrow;
                @MoveDownArrow.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveDownArrow;
                @MoveDownArrow.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveDownArrow;
                @MoveDownArrow.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveDownArrow;
                @MoveLeftArrow.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveLeftArrow;
                @MoveLeftArrow.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveLeftArrow;
                @MoveLeftArrow.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveLeftArrow;
                @MoveRightArrow.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveRightArrow;
                @MoveRightArrow.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveRightArrow;
                @MoveRightArrow.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveRightArrow;
                @MoveUpAnalogStick.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveUpAnalogStick;
                @MoveUpAnalogStick.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveUpAnalogStick;
                @MoveUpAnalogStick.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveUpAnalogStick;
                @MoveDownAnalogStick.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveDownAnalogStick;
                @MoveDownAnalogStick.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveDownAnalogStick;
                @MoveDownAnalogStick.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveDownAnalogStick;
                @MoveLeftAnalogStick.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveLeftAnalogStick;
                @MoveLeftAnalogStick.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveLeftAnalogStick;
                @MoveLeftAnalogStick.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveLeftAnalogStick;
                @MoveRightAnalogStick.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveRightAnalogStick;
                @MoveRightAnalogStick.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveRightAnalogStick;
                @MoveRightAnalogStick.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMoveRightAnalogStick;
            }
            m_Wrapper.m_PlayerUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Close.started += instance.OnClose;
                @Close.performed += instance.OnClose;
                @Close.canceled += instance.OnClose;
                @TabLeft.started += instance.OnTabLeft;
                @TabLeft.performed += instance.OnTabLeft;
                @TabLeft.canceled += instance.OnTabLeft;
                @TabRight.started += instance.OnTabRight;
                @TabRight.performed += instance.OnTabRight;
                @TabRight.canceled += instance.OnTabRight;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @AltClose.started += instance.OnAltClose;
                @AltClose.performed += instance.OnAltClose;
                @AltClose.canceled += instance.OnAltClose;
                @MoveUpArrow.started += instance.OnMoveUpArrow;
                @MoveUpArrow.performed += instance.OnMoveUpArrow;
                @MoveUpArrow.canceled += instance.OnMoveUpArrow;
                @MoveDownArrow.started += instance.OnMoveDownArrow;
                @MoveDownArrow.performed += instance.OnMoveDownArrow;
                @MoveDownArrow.canceled += instance.OnMoveDownArrow;
                @MoveLeftArrow.started += instance.OnMoveLeftArrow;
                @MoveLeftArrow.performed += instance.OnMoveLeftArrow;
                @MoveLeftArrow.canceled += instance.OnMoveLeftArrow;
                @MoveRightArrow.started += instance.OnMoveRightArrow;
                @MoveRightArrow.performed += instance.OnMoveRightArrow;
                @MoveRightArrow.canceled += instance.OnMoveRightArrow;
                @MoveUpAnalogStick.started += instance.OnMoveUpAnalogStick;
                @MoveUpAnalogStick.performed += instance.OnMoveUpAnalogStick;
                @MoveUpAnalogStick.canceled += instance.OnMoveUpAnalogStick;
                @MoveDownAnalogStick.started += instance.OnMoveDownAnalogStick;
                @MoveDownAnalogStick.performed += instance.OnMoveDownAnalogStick;
                @MoveDownAnalogStick.canceled += instance.OnMoveDownAnalogStick;
                @MoveLeftAnalogStick.started += instance.OnMoveLeftAnalogStick;
                @MoveLeftAnalogStick.performed += instance.OnMoveLeftAnalogStick;
                @MoveLeftAnalogStick.canceled += instance.OnMoveLeftAnalogStick;
                @MoveRightAnalogStick.started += instance.OnMoveRightAnalogStick;
                @MoveRightAnalogStick.performed += instance.OnMoveRightAnalogStick;
                @MoveRightAnalogStick.canceled += instance.OnMoveRightAnalogStick;
            }
        }
    }
    public PlayerUIActions @PlayerUI => new PlayerUIActions(this);
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnGameMenu(InputAction.CallbackContext context);
    }
    public interface IPlayerUIActions
    {
        void OnClose(InputAction.CallbackContext context);
        void OnTabLeft(InputAction.CallbackContext context);
        void OnTabRight(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnAltClose(InputAction.CallbackContext context);
        void OnMoveUpArrow(InputAction.CallbackContext context);
        void OnMoveDownArrow(InputAction.CallbackContext context);
        void OnMoveLeftArrow(InputAction.CallbackContext context);
        void OnMoveRightArrow(InputAction.CallbackContext context);
        void OnMoveUpAnalogStick(InputAction.CallbackContext context);
        void OnMoveDownAnalogStick(InputAction.CallbackContext context);
        void OnMoveLeftAnalogStick(InputAction.CallbackContext context);
        void OnMoveRightAnalogStick(InputAction.CallbackContext context);
    }
}
