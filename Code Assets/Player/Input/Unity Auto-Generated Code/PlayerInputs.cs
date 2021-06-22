// GENERATED AUTOMATICALLY FROM 'Assets/Code Assets/Player/Input/Unity Auto-Generated Code/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""GameplayInput"",
            ""id"": ""e8e12c0e-1028-4c8b-bb68-9b186edea29e"",
            ""actions"": [
                {
                    ""name"": ""MovePlayerBody"",
                    ""type"": ""Value"",
                    ""id"": ""5beaac76-0e32-4af2-b004-3d6a01a0d2d6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""b5168a59-9482-42cf-a7e9-7bd08dae1975"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GameMenu"",
                    ""type"": ""Button"",
                    ""id"": ""b1e74503-94d9-453b-aaa6-c01a6e5ca5b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerMenu"",
                    ""type"": ""Button"",
                    ""id"": ""a9ccfb0c-944d-4e68-b1d2-5f39e53f2a68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""da7973e6-93ec-42ca-9e47-122c12e36594"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayerBody"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09c64a94-2243-4af0-9ec5-8c0d1ad26850"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81c47e57-ee82-4c79-bc95-701f98218bd3"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GameMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b752be7e-6269-4c45-ac9e-4d56b7c64e2f"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UserInterfaceInput"",
            ""id"": ""98c8d233-2c56-471f-aba8-193f8c875798"",
            ""actions"": [
                {
                    ""name"": ""MoveCursor"",
                    ""type"": ""Value"",
                    ""id"": ""0556b718-2ef7-415a-8e61-a9e61a4ffbf6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""6ddf9b1c-52e4-4ed7-8789-b25fc53d46e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""e9e64c44-d557-4e12-8807-17ca330fa90f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""1ea6cac3-7d73-4fad-8801-7d30f027c78a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""25326ca9-4b51-410c-b2bc-05776a420daa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GameMenu"",
                    ""type"": ""Button"",
                    ""id"": ""6f8aba6e-f511-41c4-85de-0c52be8ac21a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerMenu"",
                    ""type"": ""Button"",
                    ""id"": ""b7561b9b-74ef-4a6d-993d-138446be6383"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""963b7dde-4d0b-40db-9a29-5a0101805526"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitTypeOne"",
                    ""type"": ""Button"",
                    ""id"": ""d4d489e1-a73d-490e-a8b3-7248f879a83c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitTypeTwo"",
                    ""type"": ""Button"",
                    ""id"": ""8fac2a1c-b648-40a1-a0dc-0f009ffaf017"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitTypeThree"",
                    ""type"": ""Button"",
                    ""id"": ""7aadabf6-cb4b-4418-807e-9eded0545d0c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitTypeFour"",
                    ""type"": ""Button"",
                    ""id"": ""ca8ec940-310a-4200-b330-a28ae3e99c65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftSubWindowLeft"",
                    ""type"": ""Button"",
                    ""id"": ""86503172-3414-4c2a-bec2-42a139836e24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftSubWindowRight"",
                    ""type"": ""Button"",
                    ""id"": ""8435029b-4c58-42f6-956a-657f03e8ecb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11679964-8365-4928-8878-7180928559b6"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96b43c27-9ea9-4136-9927-c192bd0308ec"",
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
                    ""id"": ""6050532b-6bf4-49c6-a549-52d0ed96d0f5"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb1f6fda-e1ca-4360-be2b-4251da15c044"",
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
                    ""id"": ""175cd199-e8d5-434b-8d1c-d5760d6343ee"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7637ca4-ab20-4dcc-b524-93200d083b73"",
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
                    ""id"": ""52412710-c9c8-44fe-a6d2-b7e0c5d3466e"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de653b69-4a20-4d70-8fa6-5f84a3221798"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53cb84b0-987d-4e30-ba78-06637935a014"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c04bfc3e-37db-4d40-b89c-8925938265a2"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GameMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf38baa4-9443-41f9-8505-8b7cf9a4e5c9"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""205f6010-f662-470d-92a2-d21263fd3694"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SubmitTypeOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69e49cdc-2daa-47a8-963a-855657e99774"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SubmitTypeTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a26235ab-034a-4c6a-99c9-aab659cb84e9"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SubmitTypeThree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c409061-cb98-4d53-8c22-56f2626c1118"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SubmitTypeFour"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b46ddc81-4881-4e82-868d-45c2fccfd83a"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96623566-9783-431a-a1fa-f1571e4a0064"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftSubWindowLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5731ad01-0dab-4d32-b5e7-5dc0fface8f9"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftSubWindowRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayInput
        m_GameplayInput = asset.FindActionMap("GameplayInput", throwIfNotFound: true);
        m_GameplayInput_MovePlayerBody = m_GameplayInput.FindAction("MovePlayerBody", throwIfNotFound: true);
        m_GameplayInput_RotateCamera = m_GameplayInput.FindAction("RotateCamera", throwIfNotFound: true);
        m_GameplayInput_GameMenu = m_GameplayInput.FindAction("GameMenu", throwIfNotFound: true);
        m_GameplayInput_PlayerMenu = m_GameplayInput.FindAction("PlayerMenu", throwIfNotFound: true);
        // UserInterfaceInput
        m_UserInterfaceInput = asset.FindActionMap("UserInterfaceInput", throwIfNotFound: true);
        m_UserInterfaceInput_MoveCursor = m_UserInterfaceInput.FindAction("MoveCursor", throwIfNotFound: true);
        m_UserInterfaceInput_Up = m_UserInterfaceInput.FindAction("Up", throwIfNotFound: true);
        m_UserInterfaceInput_Down = m_UserInterfaceInput.FindAction("Down", throwIfNotFound: true);
        m_UserInterfaceInput_Left = m_UserInterfaceInput.FindAction("Left", throwIfNotFound: true);
        m_UserInterfaceInput_Right = m_UserInterfaceInput.FindAction("Right", throwIfNotFound: true);
        m_UserInterfaceInput_GameMenu = m_UserInterfaceInput.FindAction("GameMenu", throwIfNotFound: true);
        m_UserInterfaceInput_PlayerMenu = m_UserInterfaceInput.FindAction("PlayerMenu", throwIfNotFound: true);
        m_UserInterfaceInput_Back = m_UserInterfaceInput.FindAction("Back", throwIfNotFound: true);
        m_UserInterfaceInput_SubmitTypeOne = m_UserInterfaceInput.FindAction("SubmitTypeOne", throwIfNotFound: true);
        m_UserInterfaceInput_SubmitTypeTwo = m_UserInterfaceInput.FindAction("SubmitTypeTwo", throwIfNotFound: true);
        m_UserInterfaceInput_SubmitTypeThree = m_UserInterfaceInput.FindAction("SubmitTypeThree", throwIfNotFound: true);
        m_UserInterfaceInput_SubmitTypeFour = m_UserInterfaceInput.FindAction("SubmitTypeFour", throwIfNotFound: true);
        m_UserInterfaceInput_ShiftSubWindowLeft = m_UserInterfaceInput.FindAction("ShiftSubWindowLeft", throwIfNotFound: true);
        m_UserInterfaceInput_ShiftSubWindowRight = m_UserInterfaceInput.FindAction("ShiftSubWindowRight", throwIfNotFound: true);
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

    // GameplayInput
    private readonly InputActionMap m_GameplayInput;
    private IGameplayInputActions m_GameplayInputActionsCallbackInterface;
    private readonly InputAction m_GameplayInput_MovePlayerBody;
    private readonly InputAction m_GameplayInput_RotateCamera;
    private readonly InputAction m_GameplayInput_GameMenu;
    private readonly InputAction m_GameplayInput_PlayerMenu;
    public struct GameplayInputActions
    {
        private @PlayerInputs m_Wrapper;
        public GameplayInputActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayerBody => m_Wrapper.m_GameplayInput_MovePlayerBody;
        public InputAction @RotateCamera => m_Wrapper.m_GameplayInput_RotateCamera;
        public InputAction @GameMenu => m_Wrapper.m_GameplayInput_GameMenu;
        public InputAction @PlayerMenu => m_Wrapper.m_GameplayInput_PlayerMenu;
        public InputActionMap Get() { return m_Wrapper.m_GameplayInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayInputActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayInputActions instance)
        {
            if (m_Wrapper.m_GameplayInputActionsCallbackInterface != null)
            {
                @MovePlayerBody.started -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnMovePlayerBody;
                @MovePlayerBody.performed -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnMovePlayerBody;
                @MovePlayerBody.canceled -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnMovePlayerBody;
                @RotateCamera.started -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnRotateCamera;
                @GameMenu.started -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnGameMenu;
                @GameMenu.performed -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnGameMenu;
                @GameMenu.canceled -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnGameMenu;
                @PlayerMenu.started -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnPlayerMenu;
                @PlayerMenu.performed -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnPlayerMenu;
                @PlayerMenu.canceled -= m_Wrapper.m_GameplayInputActionsCallbackInterface.OnPlayerMenu;
            }
            m_Wrapper.m_GameplayInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePlayerBody.started += instance.OnMovePlayerBody;
                @MovePlayerBody.performed += instance.OnMovePlayerBody;
                @MovePlayerBody.canceled += instance.OnMovePlayerBody;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @GameMenu.started += instance.OnGameMenu;
                @GameMenu.performed += instance.OnGameMenu;
                @GameMenu.canceled += instance.OnGameMenu;
                @PlayerMenu.started += instance.OnPlayerMenu;
                @PlayerMenu.performed += instance.OnPlayerMenu;
                @PlayerMenu.canceled += instance.OnPlayerMenu;
            }
        }
    }
    public GameplayInputActions @GameplayInput => new GameplayInputActions(this);

    // UserInterfaceInput
    private readonly InputActionMap m_UserInterfaceInput;
    private IUserInterfaceInputActions m_UserInterfaceInputActionsCallbackInterface;
    private readonly InputAction m_UserInterfaceInput_MoveCursor;
    private readonly InputAction m_UserInterfaceInput_Up;
    private readonly InputAction m_UserInterfaceInput_Down;
    private readonly InputAction m_UserInterfaceInput_Left;
    private readonly InputAction m_UserInterfaceInput_Right;
    private readonly InputAction m_UserInterfaceInput_GameMenu;
    private readonly InputAction m_UserInterfaceInput_PlayerMenu;
    private readonly InputAction m_UserInterfaceInput_Back;
    private readonly InputAction m_UserInterfaceInput_SubmitTypeOne;
    private readonly InputAction m_UserInterfaceInput_SubmitTypeTwo;
    private readonly InputAction m_UserInterfaceInput_SubmitTypeThree;
    private readonly InputAction m_UserInterfaceInput_SubmitTypeFour;
    private readonly InputAction m_UserInterfaceInput_ShiftSubWindowLeft;
    private readonly InputAction m_UserInterfaceInput_ShiftSubWindowRight;
    public struct UserInterfaceInputActions
    {
        private @PlayerInputs m_Wrapper;
        public UserInterfaceInputActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCursor => m_Wrapper.m_UserInterfaceInput_MoveCursor;
        public InputAction @Up => m_Wrapper.m_UserInterfaceInput_Up;
        public InputAction @Down => m_Wrapper.m_UserInterfaceInput_Down;
        public InputAction @Left => m_Wrapper.m_UserInterfaceInput_Left;
        public InputAction @Right => m_Wrapper.m_UserInterfaceInput_Right;
        public InputAction @GameMenu => m_Wrapper.m_UserInterfaceInput_GameMenu;
        public InputAction @PlayerMenu => m_Wrapper.m_UserInterfaceInput_PlayerMenu;
        public InputAction @Back => m_Wrapper.m_UserInterfaceInput_Back;
        public InputAction @SubmitTypeOne => m_Wrapper.m_UserInterfaceInput_SubmitTypeOne;
        public InputAction @SubmitTypeTwo => m_Wrapper.m_UserInterfaceInput_SubmitTypeTwo;
        public InputAction @SubmitTypeThree => m_Wrapper.m_UserInterfaceInput_SubmitTypeThree;
        public InputAction @SubmitTypeFour => m_Wrapper.m_UserInterfaceInput_SubmitTypeFour;
        public InputAction @ShiftSubWindowLeft => m_Wrapper.m_UserInterfaceInput_ShiftSubWindowLeft;
        public InputAction @ShiftSubWindowRight => m_Wrapper.m_UserInterfaceInput_ShiftSubWindowRight;
        public InputActionMap Get() { return m_Wrapper.m_UserInterfaceInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserInterfaceInputActions set) { return set.Get(); }
        public void SetCallbacks(IUserInterfaceInputActions instance)
        {
            if (m_Wrapper.m_UserInterfaceInputActionsCallbackInterface != null)
            {
                @MoveCursor.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnMoveCursor;
                @Up.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnRight;
                @GameMenu.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnGameMenu;
                @GameMenu.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnGameMenu;
                @GameMenu.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnGameMenu;
                @PlayerMenu.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnPlayerMenu;
                @PlayerMenu.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnPlayerMenu;
                @PlayerMenu.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnPlayerMenu;
                @Back.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnBack;
                @SubmitTypeOne.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeOne;
                @SubmitTypeOne.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeOne;
                @SubmitTypeOne.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeOne;
                @SubmitTypeTwo.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeTwo;
                @SubmitTypeTwo.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeTwo;
                @SubmitTypeTwo.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeTwo;
                @SubmitTypeThree.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeThree;
                @SubmitTypeThree.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeThree;
                @SubmitTypeThree.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeThree;
                @SubmitTypeFour.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeFour;
                @SubmitTypeFour.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeFour;
                @SubmitTypeFour.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnSubmitTypeFour;
                @ShiftSubWindowLeft.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnShiftSubWindowLeft;
                @ShiftSubWindowLeft.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnShiftSubWindowLeft;
                @ShiftSubWindowLeft.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnShiftSubWindowLeft;
                @ShiftSubWindowRight.started -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnShiftSubWindowRight;
                @ShiftSubWindowRight.performed -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnShiftSubWindowRight;
                @ShiftSubWindowRight.canceled -= m_Wrapper.m_UserInterfaceInputActionsCallbackInterface.OnShiftSubWindowRight;
            }
            m_Wrapper.m_UserInterfaceInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCursor.started += instance.OnMoveCursor;
                @MoveCursor.performed += instance.OnMoveCursor;
                @MoveCursor.canceled += instance.OnMoveCursor;
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
                @GameMenu.started += instance.OnGameMenu;
                @GameMenu.performed += instance.OnGameMenu;
                @GameMenu.canceled += instance.OnGameMenu;
                @PlayerMenu.started += instance.OnPlayerMenu;
                @PlayerMenu.performed += instance.OnPlayerMenu;
                @PlayerMenu.canceled += instance.OnPlayerMenu;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @SubmitTypeOne.started += instance.OnSubmitTypeOne;
                @SubmitTypeOne.performed += instance.OnSubmitTypeOne;
                @SubmitTypeOne.canceled += instance.OnSubmitTypeOne;
                @SubmitTypeTwo.started += instance.OnSubmitTypeTwo;
                @SubmitTypeTwo.performed += instance.OnSubmitTypeTwo;
                @SubmitTypeTwo.canceled += instance.OnSubmitTypeTwo;
                @SubmitTypeThree.started += instance.OnSubmitTypeThree;
                @SubmitTypeThree.performed += instance.OnSubmitTypeThree;
                @SubmitTypeThree.canceled += instance.OnSubmitTypeThree;
                @SubmitTypeFour.started += instance.OnSubmitTypeFour;
                @SubmitTypeFour.performed += instance.OnSubmitTypeFour;
                @SubmitTypeFour.canceled += instance.OnSubmitTypeFour;
                @ShiftSubWindowLeft.started += instance.OnShiftSubWindowLeft;
                @ShiftSubWindowLeft.performed += instance.OnShiftSubWindowLeft;
                @ShiftSubWindowLeft.canceled += instance.OnShiftSubWindowLeft;
                @ShiftSubWindowRight.started += instance.OnShiftSubWindowRight;
                @ShiftSubWindowRight.performed += instance.OnShiftSubWindowRight;
                @ShiftSubWindowRight.canceled += instance.OnShiftSubWindowRight;
            }
        }
    }
    public UserInterfaceInputActions @UserInterfaceInput => new UserInterfaceInputActions(this);
    public interface IGameplayInputActions
    {
        void OnMovePlayerBody(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnGameMenu(InputAction.CallbackContext context);
        void OnPlayerMenu(InputAction.CallbackContext context);
    }
    public interface IUserInterfaceInputActions
    {
        void OnMoveCursor(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnGameMenu(InputAction.CallbackContext context);
        void OnPlayerMenu(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnSubmitTypeOne(InputAction.CallbackContext context);
        void OnSubmitTypeTwo(InputAction.CallbackContext context);
        void OnSubmitTypeThree(InputAction.CallbackContext context);
        void OnSubmitTypeFour(InputAction.CallbackContext context);
        void OnShiftSubWindowLeft(InputAction.CallbackContext context);
        void OnShiftSubWindowRight(InputAction.CallbackContext context);
    }
}
