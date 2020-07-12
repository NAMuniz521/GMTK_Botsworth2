// GENERATED AUTOMATICALLY FROM 'Assets/GMTK_Botsworth2.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GMTK_Botsworth2"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""eb253c7e-a08b-47e4-9a22-18d4d58495cc"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e15f8f17-05ed-4b65-abee-dbcd20c74914"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""593c3ba2-b12b-4035-b2a1-8cd0b9d83862"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateShield"",
                    ""type"": ""Button"",
                    ""id"": ""88459998-1dfa-4e20-a0ff-d40d685e53e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""DeactivateShield"",
                    ""type"": ""Button"",
                    ""id"": ""3a7bfedf-296e-4eb2-888d-3028358152f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""04c19b6f-f375-45a1-a351-384302397a0c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""812e8757-fc37-42c6-b2d0-dd747af10bfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""C"",
                    ""type"": ""Button"",
                    ""id"": ""6adb469c-37fa-443b-b047-2479398bcaf3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""58f44f4c-676a-4dd7-a89f-fa5a261c6333"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""E"",
                    ""type"": ""Button"",
                    ""id"": ""47261c4a-ba02-4365-8005-296f13900ff7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""F"",
                    ""type"": ""Button"",
                    ""id"": ""914aecdf-418c-4238-bbb2-82a1303d8180"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""G"",
                    ""type"": ""Button"",
                    ""id"": ""bf85ced4-e9fa-4c08-8868-18c45272d9d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""H"",
                    ""type"": ""Button"",
                    ""id"": ""84c1fd04-f086-4623-a32f-7e8e30bc653e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""I"",
                    ""type"": ""Button"",
                    ""id"": ""68fe791d-4f6a-4a18-9ab8-ffbd69772f26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""J"",
                    ""type"": ""Button"",
                    ""id"": ""db8b5e14-994d-49a0-a012-445d15585859"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""K"",
                    ""type"": ""Button"",
                    ""id"": ""433d2449-f0df-41d2-8e0d-4e466b3471b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""L"",
                    ""type"": ""Button"",
                    ""id"": ""31cb7886-fd12-42ac-9e04-027bf37d0ba1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""M"",
                    ""type"": ""Button"",
                    ""id"": ""ee42786b-40aa-482a-abff-f2bb7e60d80e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""N"",
                    ""type"": ""Button"",
                    ""id"": ""678cb370-1d56-4f62-b1f8-e5d94560ea49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""O"",
                    ""type"": ""Button"",
                    ""id"": ""ce946ddc-7d30-4b93-81d5-fadd3686019b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""P"",
                    ""type"": ""Button"",
                    ""id"": ""5505e5b1-3369-4192-935d-5c07941bc919"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Q"",
                    ""type"": ""Button"",
                    ""id"": ""aaf17c76-3fb2-4370-8dea-33c4186c131d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""R"",
                    ""type"": ""Button"",
                    ""id"": ""6ec091ae-4523-45f1-8782-e502e72607c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""ac5af4c0-1dac-4eec-b179-143f29682bd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""T"",
                    ""type"": ""Button"",
                    ""id"": ""015d2bd1-d19c-436e-b8cb-89d1f1e415c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""U"",
                    ""type"": ""Button"",
                    ""id"": ""6283df22-863e-4ea6-b6d8-c6ead802d673"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""V"",
                    ""type"": ""Button"",
                    ""id"": ""2d1d3785-a924-47ec-86a2-8429a21c894f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""W"",
                    ""type"": ""Button"",
                    ""id"": ""4d891b08-d411-4ef4-950c-dd546f800c33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""7c4e73c4-e36a-48f6-96f3-88e386fc3d4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""497a3ded-1461-44bf-a56b-47e0b3d503e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Z"",
                    ""type"": ""Button"",
                    ""id"": ""fe201382-efd0-469a-b737-b547bd76dc8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b80fc7b-6618-43e0-9cbf-809a3d693021"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cde1316b-c5e0-4b24-90ae-309d53642e73"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e86f0291-b1a7-4b00-8cb9-f595ab445021"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d331f48-c766-4b41-a43c-3c2e7cf199c4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""89692e1b-e613-48f4-bebd-e671b049bc44"",
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
                    ""id"": ""6aafadbb-c403-470e-86e3-6f1a5429ec26"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""61cfddde-af9a-4d8b-a6cb-00c1ed3af50e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b5abc2c-386b-4ea3-a96b-8c17c745edfa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""31519aa1-0b42-4ba9-91a9-f2736cdd4c50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46068204-449d-43a5-a45a-866ffe2d1a1e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ActivateShield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c7a10d0-9872-4c1e-8364-14922eda98c7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DeactivateShield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c2bbdfe-6910-445b-9925-1129f88b468b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abf5c07d-a376-4f9d-9180-0232de4a1a60"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30f89a7e-fb72-42d7-9b01-039b8cce6c15"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2f60d35-3285-445c-8865-4afab857bdb6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76d8e0b3-309d-4e4c-a742-ce155af9c31f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1637811-d983-44a8-babd-24f6914e2e19"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""F"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c491254b-8b8e-488b-a5b9-ea3549273a60"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""G"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3247a7a-dd47-4fa1-a710-aca7012e45c9"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""H"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1b6f9d5-6589-4e03-812a-d06ba31dba8f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""I"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fa0d7c0-de61-47cd-9cb4-1defa1e02123"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""J"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9f9367e-119b-4e4f-8a47-701d4017114c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""K"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f13a898b-8c90-4117-ab61-e65bdaf7d3e6"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""450417eb-c681-4238-a149-9628131ee436"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""M"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""341b0470-ccdd-4eb4-8763-bf06df3db15f"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""N"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90c8f778-76b9-4839-9dbb-d570eb1d8b64"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""O"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a038b5c9-57b9-4caf-84b9-285c56e84aa9"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""P"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d9c4937-489c-4c1d-94d5-a94951e85ee1"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Q"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01e3b0b1-53ae-498f-b493-2a0388c9b979"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56261f51-bd38-46ed-925a-f3b48eb301c1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa409feb-9707-4194-8d80-6078abe07481"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""T"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""249da296-fd5d-4baa-bc3b-92a33b768bb1"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""U"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e308346c-d971-49db-9e29-9532704e5d85"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""V"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bc9a409-5e2c-44f5-98f0-ed31bb7f895b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be2f45a9-ae9f-48c9-9f76-498587d2f675"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""267916e5-f78d-4cb8-91c0-31cf80d624cb"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d44c74a7-771d-4da8-93d8-7cf5f1cb627b"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Z"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""dc6fb290-b542-4a82-abd8-c9cdf820ed7d"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""93d73e0c-0893-4a12-983f-3b20d1bbef5f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""9d22fb4d-77e9-4ddb-9635-5aea525b841b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""e226326d-9612-40e8-add1-7e112af5c8a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1f728e02-f1bb-4de0-9a67-b9efc689bac0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c0c96b27-6be9-4713-aa72-fb170511cb14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a0aa891b-936c-46d6-a577-925c1b0275dd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ea154e88-a2af-4e66-969c-052482588ebf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""686bb3c6-f3af-498f-9071-2f8413d26c6c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""00bf531e-4751-46d5-8347-b43f2ef4832e"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""84997f59-edf0-49bd-ba0e-038c825699d5"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9e6b34-44bf-4381-ac63-5aa15d19f677"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_ActivateShield = m_Player.FindAction("ActivateShield", throwIfNotFound: true);
        m_Player_DeactivateShield = m_Player.FindAction("DeactivateShield", throwIfNotFound: true);
        m_Player_A = m_Player.FindAction("A", throwIfNotFound: true);
        m_Player_B = m_Player.FindAction("B", throwIfNotFound: true);
        m_Player_C = m_Player.FindAction("C", throwIfNotFound: true);
        m_Player_D = m_Player.FindAction("D", throwIfNotFound: true);
        m_Player_E = m_Player.FindAction("E", throwIfNotFound: true);
        m_Player_F = m_Player.FindAction("F", throwIfNotFound: true);
        m_Player_G = m_Player.FindAction("G", throwIfNotFound: true);
        m_Player_H = m_Player.FindAction("H", throwIfNotFound: true);
        m_Player_I = m_Player.FindAction("I", throwIfNotFound: true);
        m_Player_J = m_Player.FindAction("J", throwIfNotFound: true);
        m_Player_K = m_Player.FindAction("K", throwIfNotFound: true);
        m_Player_L = m_Player.FindAction("L", throwIfNotFound: true);
        m_Player_M = m_Player.FindAction("M", throwIfNotFound: true);
        m_Player_N = m_Player.FindAction("N", throwIfNotFound: true);
        m_Player_O = m_Player.FindAction("O", throwIfNotFound: true);
        m_Player_P = m_Player.FindAction("P", throwIfNotFound: true);
        m_Player_Q = m_Player.FindAction("Q", throwIfNotFound: true);
        m_Player_R = m_Player.FindAction("R", throwIfNotFound: true);
        m_Player_S = m_Player.FindAction("S", throwIfNotFound: true);
        m_Player_T = m_Player.FindAction("T", throwIfNotFound: true);
        m_Player_U = m_Player.FindAction("U", throwIfNotFound: true);
        m_Player_V = m_Player.FindAction("V", throwIfNotFound: true);
        m_Player_W = m_Player.FindAction("W", throwIfNotFound: true);
        m_Player_X = m_Player.FindAction("X", throwIfNotFound: true);
        m_Player_Y = m_Player.FindAction("Y", throwIfNotFound: true);
        m_Player_Z = m_Player.FindAction("Z", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_ActivateShield;
    private readonly InputAction m_Player_DeactivateShield;
    private readonly InputAction m_Player_A;
    private readonly InputAction m_Player_B;
    private readonly InputAction m_Player_C;
    private readonly InputAction m_Player_D;
    private readonly InputAction m_Player_E;
    private readonly InputAction m_Player_F;
    private readonly InputAction m_Player_G;
    private readonly InputAction m_Player_H;
    private readonly InputAction m_Player_I;
    private readonly InputAction m_Player_J;
    private readonly InputAction m_Player_K;
    private readonly InputAction m_Player_L;
    private readonly InputAction m_Player_M;
    private readonly InputAction m_Player_N;
    private readonly InputAction m_Player_O;
    private readonly InputAction m_Player_P;
    private readonly InputAction m_Player_Q;
    private readonly InputAction m_Player_R;
    private readonly InputAction m_Player_S;
    private readonly InputAction m_Player_T;
    private readonly InputAction m_Player_U;
    private readonly InputAction m_Player_V;
    private readonly InputAction m_Player_W;
    private readonly InputAction m_Player_X;
    private readonly InputAction m_Player_Y;
    private readonly InputAction m_Player_Z;
    public struct PlayerActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @ActivateShield => m_Wrapper.m_Player_ActivateShield;
        public InputAction @DeactivateShield => m_Wrapper.m_Player_DeactivateShield;
        public InputAction @A => m_Wrapper.m_Player_A;
        public InputAction @B => m_Wrapper.m_Player_B;
        public InputAction @C => m_Wrapper.m_Player_C;
        public InputAction @D => m_Wrapper.m_Player_D;
        public InputAction @E => m_Wrapper.m_Player_E;
        public InputAction @F => m_Wrapper.m_Player_F;
        public InputAction @G => m_Wrapper.m_Player_G;
        public InputAction @H => m_Wrapper.m_Player_H;
        public InputAction @I => m_Wrapper.m_Player_I;
        public InputAction @J => m_Wrapper.m_Player_J;
        public InputAction @K => m_Wrapper.m_Player_K;
        public InputAction @L => m_Wrapper.m_Player_L;
        public InputAction @M => m_Wrapper.m_Player_M;
        public InputAction @N => m_Wrapper.m_Player_N;
        public InputAction @O => m_Wrapper.m_Player_O;
        public InputAction @P => m_Wrapper.m_Player_P;
        public InputAction @Q => m_Wrapper.m_Player_Q;
        public InputAction @R => m_Wrapper.m_Player_R;
        public InputAction @S => m_Wrapper.m_Player_S;
        public InputAction @T => m_Wrapper.m_Player_T;
        public InputAction @U => m_Wrapper.m_Player_U;
        public InputAction @V => m_Wrapper.m_Player_V;
        public InputAction @W => m_Wrapper.m_Player_W;
        public InputAction @X => m_Wrapper.m_Player_X;
        public InputAction @Y => m_Wrapper.m_Player_Y;
        public InputAction @Z => m_Wrapper.m_Player_Z;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @ActivateShield.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateShield;
                @ActivateShield.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateShield;
                @ActivateShield.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateShield;
                @DeactivateShield.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeactivateShield;
                @DeactivateShield.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeactivateShield;
                @DeactivateShield.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeactivateShield;
                @A.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @C.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnC;
                @C.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnC;
                @C.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnC;
                @D.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @E.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnE;
                @E.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnE;
                @E.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnE;
                @F.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnF;
                @F.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnF;
                @F.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnF;
                @G.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnG;
                @G.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnG;
                @G.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnG;
                @H.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnH;
                @H.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnH;
                @H.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnH;
                @I.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnI;
                @I.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnI;
                @I.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnI;
                @J.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJ;
                @J.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJ;
                @J.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJ;
                @K.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnK;
                @K.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnK;
                @K.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnK;
                @L.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL;
                @L.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL;
                @L.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL;
                @M.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnM;
                @M.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnM;
                @M.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnM;
                @N.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnN;
                @N.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnN;
                @N.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnN;
                @O.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnO;
                @O.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnO;
                @O.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnO;
                @P.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnP;
                @P.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnP;
                @P.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnP;
                @Q.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ;
                @Q.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ;
                @Q.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ;
                @R.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR;
                @R.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR;
                @R.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR;
                @S.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @T.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnT;
                @T.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnT;
                @T.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnT;
                @U.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnU;
                @U.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnU;
                @U.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnU;
                @V.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnV;
                @V.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnV;
                @V.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnV;
                @W.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @W.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @W.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @X.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Z.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZ;
                @Z.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZ;
                @Z.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZ;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ActivateShield.started += instance.OnActivateShield;
                @ActivateShield.performed += instance.OnActivateShield;
                @ActivateShield.canceled += instance.OnActivateShield;
                @DeactivateShield.started += instance.OnDeactivateShield;
                @DeactivateShield.performed += instance.OnDeactivateShield;
                @DeactivateShield.canceled += instance.OnDeactivateShield;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @C.started += instance.OnC;
                @C.performed += instance.OnC;
                @C.canceled += instance.OnC;
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
                @E.started += instance.OnE;
                @E.performed += instance.OnE;
                @E.canceled += instance.OnE;
                @F.started += instance.OnF;
                @F.performed += instance.OnF;
                @F.canceled += instance.OnF;
                @G.started += instance.OnG;
                @G.performed += instance.OnG;
                @G.canceled += instance.OnG;
                @H.started += instance.OnH;
                @H.performed += instance.OnH;
                @H.canceled += instance.OnH;
                @I.started += instance.OnI;
                @I.performed += instance.OnI;
                @I.canceled += instance.OnI;
                @J.started += instance.OnJ;
                @J.performed += instance.OnJ;
                @J.canceled += instance.OnJ;
                @K.started += instance.OnK;
                @K.performed += instance.OnK;
                @K.canceled += instance.OnK;
                @L.started += instance.OnL;
                @L.performed += instance.OnL;
                @L.canceled += instance.OnL;
                @M.started += instance.OnM;
                @M.performed += instance.OnM;
                @M.canceled += instance.OnM;
                @N.started += instance.OnN;
                @N.performed += instance.OnN;
                @N.canceled += instance.OnN;
                @O.started += instance.OnO;
                @O.performed += instance.OnO;
                @O.canceled += instance.OnO;
                @P.started += instance.OnP;
                @P.performed += instance.OnP;
                @P.canceled += instance.OnP;
                @Q.started += instance.OnQ;
                @Q.performed += instance.OnQ;
                @Q.canceled += instance.OnQ;
                @R.started += instance.OnR;
                @R.performed += instance.OnR;
                @R.canceled += instance.OnR;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
                @T.started += instance.OnT;
                @T.performed += instance.OnT;
                @T.canceled += instance.OnT;
                @U.started += instance.OnU;
                @U.performed += instance.OnU;
                @U.canceled += instance.OnU;
                @V.started += instance.OnV;
                @V.performed += instance.OnV;
                @V.canceled += instance.OnV;
                @W.started += instance.OnW;
                @W.performed += instance.OnW;
                @W.canceled += instance.OnW;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Z.started += instance.OnZ;
                @Z.performed += instance.OnZ;
                @Z.canceled += instance.OnZ;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @PlayerInputAction m_Wrapper;
        public UIActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnActivateShield(InputAction.CallbackContext context);
        void OnDeactivateShield(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnC(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnE(InputAction.CallbackContext context);
        void OnF(InputAction.CallbackContext context);
        void OnG(InputAction.CallbackContext context);
        void OnH(InputAction.CallbackContext context);
        void OnI(InputAction.CallbackContext context);
        void OnJ(InputAction.CallbackContext context);
        void OnK(InputAction.CallbackContext context);
        void OnL(InputAction.CallbackContext context);
        void OnM(InputAction.CallbackContext context);
        void OnN(InputAction.CallbackContext context);
        void OnO(InputAction.CallbackContext context);
        void OnP(InputAction.CallbackContext context);
        void OnQ(InputAction.CallbackContext context);
        void OnR(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnT(InputAction.CallbackContext context);
        void OnU(InputAction.CallbackContext context);
        void OnV(InputAction.CallbackContext context);
        void OnW(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnZ(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
}
