/*
 * Copyright (c) 2018-2023, FusionAuth, All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */


using System.Collections.Generic;
using System;

namespace io.fusionauth.domain.webauthn {

  /**
   * Contains attributes for the Relying Party to refer to an existing public key credential as an input parameter.
   *
   * @author Spencer Witt
   */
  public class PublicKeyCredentialDescriptor {

    public string id;

    public List<string> transports;

    public PublicKeyCredentialType type;

    public PublicKeyCredentialDescriptor with(Action<PublicKeyCredentialDescriptor> action) {
      action(this);
      return this;
    }
  }
}
